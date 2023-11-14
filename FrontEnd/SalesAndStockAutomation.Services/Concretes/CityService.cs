using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;
using System.Net.Http.Json;

namespace SalesAndStockAutomation.Services.Concretes;

public class CityService : ICityService
{
    private IDomainService _domainService;
    private HttpClient _httpClient;

    public CityService(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }
    public async Task<City> AddAsync(City entity)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_domainService.Domain() + "api/Cities/", entity);
        return await response.Content.ReadFromJsonAsync<City>();
    }

    public async Task<bool> DeleteAsync(int id)
    {
        HttpResponseMessage response = await _httpClient.DeleteAsync(_domainService.Domain() + $"api/Cities/{id}");
        return response.IsSuccessStatusCode;
    }

    public async Task<List<City>> GetAllAsync()
    {
        List<City>? response = await _httpClient.GetFromJsonAsync<List<City>>(_domainService.Domain() + "api/Cities/");
        return response;
    }

    public async Task<City> GetByIdAsync(int id)
    {
        City? response = await _httpClient.GetFromJsonAsync<City>(_domainService.Domain() + $"api/Cities/{id}");
        return response;
    }

    public async Task<List<City>> GetCityByParentAsync(int parentId, int skip, int take)
    {
        List<City>? response = await _httpClient.GetFromJsonAsync<List<City>>(_domainService.Domain() + $"api/Cities/{parentId}/{skip}/{take}");
        return response;
    }

    public async Task<List<City>> GetCityListAsync(int skip, int take)
    {
        List<City>? response = await _httpClient.GetFromJsonAsync<List<City>>(_domainService.Domain() + $"api/Cities/{skip}/{take}");
        return response;
    }

    public async Task<bool> IsThereATerritoryAsync(int parentId)
    {
        return await _httpClient.GetFromJsonAsync<bool>(_domainService.Domain() + $"api/Cities/isThereATerritory/{parentId}");
    }

    public async void MultiDelete(List<City> entities)
    {
        foreach (City city in entities)
        {
            await _httpClient.DeleteAsync(_domainService.Domain() + $"api/Cities/{city.Id}");
        }
    }

    public async Task<City> UpdateAsync(City entity)
    {
        HttpResponseMessage? response = await _httpClient.PutAsJsonAsync(_domainService.Domain() + "api/Cities/", entity);
        return await response.Content.ReadFromJsonAsync<City>();
    }
}
