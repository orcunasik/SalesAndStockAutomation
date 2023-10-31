using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;
using System.Net.Http.Json;

namespace SalesAndStockAutomation.Services.Concretes;

public class CategoryService : ICategoryService
{
    private IDomainService _domainService;
    private HttpClient _httpClient;

    public CategoryService(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }

    public async Task<Category> AddAsync(Category entity)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_domainService.Domain()+"/api/Categories/", entity);
        return await response.Content.ReadFromJsonAsync<Category>();
    }

    public async void Delete(int id)
    {
        await _httpClient.DeleteAsync(_domainService.Domain() + $"/api/Categories/{id}");
    }

    public async Task<List<Category>> GetAllAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<List<Category>>(_domainService.Domain() + "/api/Categories/");
        return result;
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        var result = await _httpClient.GetFromJsonAsync<Category>(_domainService.Domain() + $"/api/Categories/{id}");
        return result;
    }

    public async Task<List<Category>> PagingAsync(int skip, int take)
    {
        var result = await _httpClient.GetFromJsonAsync<List<Category>>(_domainService.Domain() + $"/api/Categories/{skip}/{take}");
        return result;
    }

    public async Task<Category> UpdateAsync(Category entity)
    {
        HttpResponseMessage response = await _httpClient.PutAsJsonAsync(_domainService.Domain() + "/api/Categories/", entity);
        return await response.Content.ReadFromJsonAsync<Category>();
    }
}
