using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class SaleService : ISaleService
{
    private ISaleRepository _repository;

    public SaleService(ISaleRepository repository)
    {
        _repository = repository;
    }

    public Sale Add(Sale entity)
    {
        return _repository.Add(entity);
    }

    public void Delete(Sale entity)
    {
        _repository.Delete(entity);
    }

    public List<Sale> GetAll()
    {
        return _repository.GetList();
    }

    public Sale GetById(int id)
    {
        return _repository.Get(s => s.Id == id);
    }

    public List<Sale> Paging(int skip, int take)
    {
        return _repository.Paging(skip, take);
    }

    public Sale Update(Sale entity)
    {
        return _repository.Update(entity);
    }
}
