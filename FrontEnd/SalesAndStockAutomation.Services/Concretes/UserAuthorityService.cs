using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;
using System.Net.Http.Json;

namespace SalesAndStockAutomation.Services.Concretes;

public class UserAuthorityService : IUserAuthorityService
{
    private IDomainService _domainService;
    private HttpClient _httpClient;

    public UserAuthorityService(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }

    public async Task<UserAuthority> AddAsync(UserAuthority entity)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_domainService.Domain() + "api/UserAuthorities/", entity);
        return await response.Content.ReadFromJsonAsync<UserAuthority>();
    }

    public async void Delete(int id)
    {
        await _httpClient.DeleteAsync(_domainService.Domain() + $"api/UserAuthorities/{id}");
    }

    public async Task<List<UserAuthority>> GetAllAsync()
    {
        List<UserAuthority>? response = await _httpClient.GetFromJsonAsync<List<UserAuthority>>(_domainService.Domain() + "api/UserAuthorities/");
        return response;
    }

    public async Task<UserAuthority> GetByIdAsync(int id)
    {
        UserAuthority? response = await _httpClient.GetFromJsonAsync<UserAuthority>(_domainService.Domain() + $"api/UserAuthorities/{id}");
        return response;
    }

    public async Task<List<Employee>> GetEmployeesByAuthorityIdAsync(int authorityId,  int skip, int take)
    {
        List<Employee>? response = await _httpClient.GetFromJsonAsync<List<Employee>>(_domainService.Domain() + $"api/UserAuthorities/{authorityId}/{skip}/{take}");
        return response;
    }

    public async Task<UserAuthority> UpdateAsync(UserAuthority entity)
    {
        HttpResponseMessage? response = await _httpClient.PutAsJsonAsync(_domainService.Domain() + "api/UserAuthorities/", entity);
        return await response.Content.ReadFromJsonAsync<UserAuthority>();
    }
}
