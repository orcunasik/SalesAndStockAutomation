using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class ProductService : IProductService
{
    public Task<Product> AddAsync(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetProductsByCategoryAsync(int categoryId, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<Product> UpdateAsync(Product entity)
    {
        throw new NotImplementedException();
    }
}
