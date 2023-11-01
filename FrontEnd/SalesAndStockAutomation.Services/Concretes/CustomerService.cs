using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;
using System.Net.Http.Json;

namespace SalesAndStockAutomation.Services.Concretes;

public class CustomerService : ICustomerService
{
    private IDomainService _domainService;
    private HttpClient _httpClient;

    public CustomerService(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }
    public async Task<Customer> AddAsync(Customer entity)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_domainService.Domain() + "api/Customers/", entity);
        return await response.Content.ReadFromJsonAsync<Customer>();
    }

    public async void Delete(int id)
    {
        await _httpClient.DeleteAsync(_domainService.Domain() + $"api/Customers/{id}");
    }

    public async Task<List<Customer>> GetAllAsync()
    {
        List<Customer>? response = await _httpClient.GetFromJsonAsync<List<Customer>>(_domainService.Domain() + "api/Customers/");
        return response;
    }

    public async Task<Customer> GetByIdAsync(int id)
    {
        Customer? response = await _httpClient.GetFromJsonAsync<Customer>(_domainService.Domain() + $"api/Customers/{id}");
        return response;
    }

    public async Task<List<Customer>> PagingAsync(int skip, int take)
    {
        List<Customer>? response = await _httpClient.GetFromJsonAsync<List<Customer>>(_domainService.Domain() + $"api/Customers/{skip}/{take}");
        return response;
    }

    public async Task<Customer> UpdateAsync(Customer entity)
    {
        HttpResponseMessage? response = await _httpClient.PutAsJsonAsync(_domainService.Domain() + "api/Customers/", entity);
        return await response.Content.ReadFromJsonAsync<Customer>();
    }
}
