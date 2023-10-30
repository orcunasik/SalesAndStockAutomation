using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface IProductService
{
    List<Product> GetAll();
    List<Product> GetProductsByCategory(int categoryId, int skip, int take);
    Product GetById(int id);
    Product Add(Product entity);
    Product Update(Product entity);
    void Delete(Product entity);
}
