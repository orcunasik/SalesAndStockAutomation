using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface IStockService
{
    List<Stock> GetAll();
    List<Stock> Paging(int skip, int take);
    Stock GetById(int id);
    Stock Add(Stock entity);
    Stock Update(Stock entity);
    void Delete(Stock entity);
}
