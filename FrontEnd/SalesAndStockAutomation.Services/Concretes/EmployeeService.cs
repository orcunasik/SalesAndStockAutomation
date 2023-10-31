using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class EmployeeService : IEmployeeService
{
    public Task<Employee> AddAsync(Employee entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Employee entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Employee>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Employee> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> UpdateAsync(Employee entity)
    {
        throw new NotImplementedException();
    }
}
