using SalesAndStockAutomation.Base.DB.Interface;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Abstracts;

public interface IProductRepository : IRepositoryService<Product>
{
    List<Product> GetProductsByCategoryId(int categoryId, int skip, int take);
}
