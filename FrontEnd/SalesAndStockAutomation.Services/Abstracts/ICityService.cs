using SalesAndStockAutomation.Models.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface ICityService
{
    Task<List<City>> GetAllAsync();
    Task<List<City>> GetCityByParentAsync(int parentId, int skip, int take);
    Task<City> GetByIdAsync(int id);
    Task<City> AddAsync(City entity);
    Task<City> UpdateAsync(City entity);
    void Delete(City entity);
    void MultiDelete(List<City> entities);
}
