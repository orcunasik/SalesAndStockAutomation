using SalesAndStockAutomation.Models.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface ICustomerService
{
    Task<List<Customer>> GetAllAsync();
    Task<List<Customer>> PagingAsync(int skip, int take);
    Task<Customer> GetByIdAsync(int id);
    Task<Customer> AddAsync(Customer entity);
    Task<Customer> UpdateAsync(Customer entity);
    void Delete(Customer entity);
}
