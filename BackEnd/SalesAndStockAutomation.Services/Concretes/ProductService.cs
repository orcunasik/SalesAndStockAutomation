using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class ProductService : IProductService
{
    private IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public Product Add(Product entity)
    {
        return _repository.Add(entity);
    }

    public void Delete(Product entity)
    {
        _repository.Delete(entity);
    }

    public List<Product> GetAll()
    {
        return _repository.GetList();
    }

    public Product GetById(int id)
    {
        return _repository.Get(p => p.Id == id);
    }

    public List<Product> GetProductsByCategory(int categoryId, int skip, int take)
    {
        return _repository.GetProductsByCategoryId(categoryId, skip, take);
    }

    public Product Update(Product entity)
    {
        return _repository.Update(entity);
    }
}
