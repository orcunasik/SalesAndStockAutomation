using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;
using System.Net.Http.Json;

namespace SalesAndStockAutomation.Services.Concretes;

public class AuthorityService : IAuthorityService
{
    private IDomainService _domainService;
    private HttpClient _httpClient;

    public AuthorityService(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }
    public async Task<Authority> AddAsync(Authority entity)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_domainService.Domain() + "api/Authorities/", entity);
        return await response.Content.ReadFromJsonAsync<Authority>();
    }

    public async void Delete(int id)
    {
        await _httpClient.DeleteAsync(_domainService.Domain() + $"api/Authorities/{id}");
    }

    public async Task<List<Authority>> GetAllAsync()
    {
        List<Authority>? response = await _httpClient.GetFromJsonAsync<List<Authority>>(_domainService.Domain() + "api/Authorities/");
        return response;
    }

    public async Task<Authority> GetAuthorityAsync(int id)
    {
        Authority? response = await _httpClient.GetFromJsonAsync<Authority>(_domainService.Domain() + "api/Authorities/");
        return response;
    }

    public async Task<Authority> UpdateAsync(Authority entity)
    {
        HttpResponseMessage response = await _httpClient.PutAsJsonAsync(_domainService.Domain() + "api/Authorities/", entity);
        return await response.Content.ReadFromJsonAsync<Authority>();
    }
}
