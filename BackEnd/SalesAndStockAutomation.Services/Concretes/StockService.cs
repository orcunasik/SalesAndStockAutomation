using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class StockService : IStockService
{
    private IStockRepository _repository;

    public StockService(IStockRepository repository)
    {
        _repository = repository;
    }

    public Stock Add(Stock entity)
    {
        return _repository.Add(entity);
    }

    public void Delete(Stock entity)
    {
        _repository.Delete(entity);
    }

    public List<Stock> GetAll()
    {
        return _repository.GetList();
    }

    public Stock GetById(int id)
    {
        return _repository.Get(s => s.Id == id);
    }

    public List<Stock> Paging(int skip, int take)
    {
        return _repository.Paging(skip, take);
    }

    public Stock Update(Stock entity)
    {
        return _repository.Update(entity);
    }
}
