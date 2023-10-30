using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class CategoryService : ICategoryService
{
    private ICategoryRepository _repository;

    public CategoryService(ICategoryRepository repository)
    {
        _repository = repository;
    }

    public Category Add(Category entity)
    {
        return _repository.Add(entity);
    }

    public void Delete(Category entity)
    {
        _repository.Delete(entity);
    }

    public List<Category> GetAll()
    {
        return _repository.GetList();
    }

    public Category GetById(int id)
    {
        return _repository.Get(c => c.Id == id);
    }

    public List<Category> Paging(int skip, int take)
    {
        return _repository.Paging(skip, take);
    }

    public Category Update(Category entity)
    {
        return _repository.Update(entity);
    }
}
