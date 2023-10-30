using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class CustomerService : ICustomerService
{
    private ICustomerRepository _repository;

    public CustomerService(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public Customer Add(Customer entity)
    {
        return _repository.Add(entity);
    }

    public void Delete(Customer entity)
    {
        _repository.Delete(entity);
    }

    public List<Customer> GetAll()
    {
        return _repository.GetList();
    }

    public Customer GetById(int id)
    {
        return _repository.Get(c => c.Id == id);
    }

    public List<Customer> Paging(int skip, int take)
    {
        return _repository.Paging(skip, take);
    }

    public Customer Update(Customer entity)
    {
        return _repository.Update(entity);
    }
}
