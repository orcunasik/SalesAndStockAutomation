using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class CityService : ICityService
{
    public Task<City> AddAsync(City entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(City entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<City>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<City> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<City>> GetCityByParentAsync(int parentId, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public void MultiDelete(List<City> entities)
    {
        throw new NotImplementedException();
    }

    public Task<City> UpdateAsync(City entity)
    {
        throw new NotImplementedException();
    }
}
