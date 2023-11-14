using SalesAndStockAutomation.Base.DB.Interface;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Abstracts;

public interface ICityRepository : IRepositoryService<City>
{
    List<City> GetCityByParentId(int parentId, int skip, int take);
    List<City> GetCities(int skip, int take);
    bool IsThereATerritory(int parentId);
    void MultipleDeletion(List<City> cities);
}
