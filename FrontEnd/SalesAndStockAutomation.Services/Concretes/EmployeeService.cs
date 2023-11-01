using SalesAndStockAutomation.Configurations;
using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;
using System.Net.Http.Json;

namespace SalesAndStockAutomation.Services.Concretes;

public class EmployeeService : IEmployeeService
{
    private IDomainService _domainService;
    private HttpClient _httpClient;

    public EmployeeService(IDomainService domainService, HttpClient httpClient)
    {
        _domainService = domainService;
        _httpClient = httpClient;
    }

    public async Task<Employee> AddAsync(Employee entity)
    {
        HttpResponseMessage response = await _httpClient.PostAsJsonAsync(_domainService.Domain() + "api/Employees/", entity);
        return await response.Content.ReadFromJsonAsync<Employee>();
    }

    public async void Delete(int id)
    {
        await _httpClient.DeleteAsync(_domainService.Domain() + $"api/Employees/{id}");
    }

    public async Task<List<Employee>> GetAllAsync()
    {
        List<Employee>? response = await _httpClient.GetFromJsonAsync<List<Employee>>(_domainService.Domain() + "api/Employees/");
        return response;
    }

    public async Task<Employee> GetByIdAsync(int id)
    {
        Employee? response = await _httpClient.GetFromJsonAsync<Employee>(_domainService.Domain() + $"api/Employees/{id}");
        return response;
    }

    public async Task<Employee> UpdateAsync(Employee entity)
    {
        HttpResponseMessage? response = await _httpClient.PutAsJsonAsync(_domainService.Domain() + "api/Employees/", entity);
        return await response.Content.ReadFromJsonAsync<Employee>();
    }
}
