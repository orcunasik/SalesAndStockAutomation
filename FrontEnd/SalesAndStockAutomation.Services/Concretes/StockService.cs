using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;
using System.Net.Http.Json;

namespace SalesAndStockAutomation.Services.Concretes;

public class StockService : IStockService
{
    private IDomainService _domainService;
    private HttpClient _httpClient;

    public StockService(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }

    public async Task<Stock> AddAsync(Stock entity)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_domainService.Domain() + "api/Stocks/", entity);
        return await response.Content.ReadFromJsonAsync<Stock>();
    }

    public async void Delete(int id)
    {
        await _httpClient.DeleteAsync(_domainService.Domain() + $"api/Stocks/{id}");
    }

    public async Task<List<Stock>> GetAllAsync()
    {
        List<Stock>? response = await _httpClient.GetFromJsonAsync<List<Stock>>(_domainService.Domain() + "api/Stocks/");
        return response;
    }

    public async Task<Stock> GetByIdAsync(int id)
    {
        Stock? response = await _httpClient.GetFromJsonAsync<Stock>(_domainService.Domain() + $"api/Stocks/{id}");
        return response;
    }

    public async Task<List<Stock>> PagingAsync(int skip, int take)
    {
        List<Stock>? response = await _httpClient.GetFromJsonAsync<List<Stock>>(_domainService.Domain() + $"api/Stocks/{skip}/{take}");
        return response;
    }

    public async Task<Stock> UpdateAsync(Stock entity)
    {
        HttpResponseMessage? response = await _httpClient.PutAsJsonAsync(_domainService.Domain() + "api/Stocks/", entity);
        return await response.Content.ReadFromJsonAsync<Stock>();
    }
}
