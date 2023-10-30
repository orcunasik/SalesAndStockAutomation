using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface ICityService
{
    List<City> GetAll();
    List<City> GetCityByParent(int parentId, int skip, int take);
    City GetById(int id);
    City Add(City entity);
    City Update(City entity);
    void Delete(City entity);
    void MultiDelete(List<City> entities);
}
