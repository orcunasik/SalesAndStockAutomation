using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;
using System.Net.Http.Json;

namespace SalesAndStockAutomation.Services.Concretes;

public class ProductService : IProductService
{
    private IDomainService _domainService;
    private HttpClient _httpClient;

    public ProductService(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }

    public async Task<Product> AddAsync(Product entity)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_domainService.Domain() + "api/Products/", entity);
        return await response.Content.ReadFromJsonAsync<Product>();
    }

    public async void Delete(int id)
    {
        await _httpClient.DeleteAsync(_domainService.Domain() + $"api/Products/{id}");
    }

    public async Task<List<Product>> GetAllAsync()
    {
        List<Product>? response = await _httpClient.GetFromJsonAsync<List<Product>>(_domainService.Domain() + "api/Products/");
        return response;
    }

    public async Task<Product> GetByIdAsync(int id)
    {
        Product? response = await _httpClient.GetFromJsonAsync<Product>(_domainService.Domain() + $"api/Products/{id}");
        return response;
    }

    public async Task<List<Product>> GetProductsByCategoryAsync(int categoryId, int skip, int take)
    {
        List<Product>? response = await _httpClient.GetFromJsonAsync<List<Product>>(_domainService.Domain() + $"api/Products/{categoryId}/{skip}/{take}");
        return response;
    }

    public async Task<Product> UpdateAsync(Product entity)
    {
        HttpResponseMessage? response = await _httpClient.PutAsJsonAsync(_domainService.Domain() + "api/Products/", entity);
        return await response.Content.ReadFromJsonAsync<Product>();
    }
}
