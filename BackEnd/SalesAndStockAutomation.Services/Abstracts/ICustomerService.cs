using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface ICustomerService
{
    List<Customer> GetAll();
    List<Customer> Paging(int skip, int take);
    Customer GetById(int id);
    Customer Add(Customer entity);
    Customer Update(Customer entity);
    void Delete(Customer entity);
}
