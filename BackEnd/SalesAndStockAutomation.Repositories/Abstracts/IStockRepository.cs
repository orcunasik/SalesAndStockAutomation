using SalesAndStockAutomation.Base.DB.Interface;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Abstracts;

public interface IStockRepository : IRepositoryService<Stock>
{
    List<Stock> Paging(int skip, int take);
}
