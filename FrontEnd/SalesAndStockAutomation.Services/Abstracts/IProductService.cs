using SalesAndStockAutomation.Models.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface IProductService
{
    Task<List<Product>> GetAllAsync();
    Task<List<Product>> GetProductsByCategoryAsync(int categoryId, int skip, int take);
    Task<Product> GetByIdAsync(int id);
    Task<Product> AddAsync(Product entity);
    Task<Product> UpdateAsync(Product entity);
    void Delete(Product entity);
}
