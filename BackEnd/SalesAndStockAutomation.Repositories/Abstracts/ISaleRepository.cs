using SalesAndStockAutomation.Base.DB.Interface;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Abstracts;

public interface ISaleRepository : IRepositoryService<Sale>
{
    List<Sale> Paging(int skip, int take);
}
