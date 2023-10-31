using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class CustomerService : ICustomerService
{
    public Task<Customer> AddAsync(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Customer entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Customer>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Customer> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Customer>> PagingAsync(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> UpdateAsync(Customer entity)
    {
        throw new NotImplementedException();
    }
}
