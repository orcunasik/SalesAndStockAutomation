using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class CityService : ICityService
{
    private ICityRepository _repository;

    public CityService(ICityRepository repository)
    {
        _repository = repository;
    }

    public City Add(City entity)
    {
        return _repository.Add(entity);
    }

    public void Delete(City entity)
    {
        _repository.Delete(entity);
    }

    public List<City> GetAll()
    {
        return _repository.GetList();
    }

    public City GetById(int id)
    {
        return _repository.Get(c => c.Id == id);
    }

    public List<City> GetCityByParent(int parentId, int skip, int take)
    {
        return _repository.GetCityByParentId(parentId, skip, take);
    }

    public void MultiDelete(List<City> entities)
    {
        _repository.MultipleDeletion(entities);
    }

    public City Update(City entity)
    {
        return _repository.Update(entity);
    }
}
