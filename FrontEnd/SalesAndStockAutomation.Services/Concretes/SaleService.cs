using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;
using System.Net.Http.Json;

namespace SalesAndStockAutomation.Services.Concretes;

public class SaleService : ISaleService
{
    private IDomainService _domainService;
    private HttpClient _httpClient;

    public SaleService(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }

    public async Task<Sale> AddAsync(Sale entity)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_domainService.Domain() + "api/Sales/", entity);
        return await response.Content.ReadFromJsonAsync<Sale>();
    }

    public async void Delete(int id)
    {
        await _httpClient.DeleteAsync(_domainService.Domain() + $"api/Sales/{id}");
    }

    public async Task<List<Sale>> GetAllAsync()
    {
        List<Sale>? response = await _httpClient.GetFromJsonAsync<List<Sale>>(_domainService.Domain() + "api/Sales/");
        return response;
    }

    public async Task<Sale> GetByIdAsync(int id)
    {
        Sale? response = await _httpClient.GetFromJsonAsync<Sale>(_domainService.Domain() + $"api/Sales/{id}");
        return response;
    }

    public async Task<List<Sale>> PagingAsync(int skip, int take)
    {
        List<Sale>? response = await _httpClient.GetFromJsonAsync<List<Sale>>(_domainService.Domain() + $"api/Sales/{skip}/{take}");
        return response;
    }

    public async Task<Sale> UpdateAsync(Sale entity)
    {
        HttpResponseMessage? response = await _httpClient.PutAsJsonAsync(_domainService.Domain() + "api/Sales/", entity);
        return await response.Content.ReadFromJsonAsync<Sale>();
    }
}
