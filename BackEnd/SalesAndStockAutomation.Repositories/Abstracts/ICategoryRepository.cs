using SalesAndStockAutomation.Base.DB.Interface;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Abstracts;

public interface ICategoryRepository : IRepositoryService<Category>
{
    List<Category> Paging(int skip,int take);
}
