using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface ISaleService
{
    List<Sale> GetAll();
    List<Sale> Paging(int skip, int take);
    Sale GetById(int id);
    Sale Add(Sale entity);
    Sale Update(Sale entity);
    void Delete(Sale entity);
}
