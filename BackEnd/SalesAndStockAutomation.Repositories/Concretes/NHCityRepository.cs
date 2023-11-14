using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Base.DB.Manager;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;

namespace SalesAndStockAutomation.Repositories.Concretes;

public class NHCityRepository : RepositoryService<City>, ICityRepository
{
    private NHibernateHelper _nHibernateHelper;
    public NHCityRepository(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
    {
        _nHibernateHelper = nHibernateHelper;
    }

    public List<City> GetCities(int skip, int take)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            List<City> cities = session.Query<City>()
                .Where(c => c.ParentId == 0)
                .OrderBy(c => c.Name)
                .Skip(skip).Take(take).ToList();
            return cities;
        }
    }

    public List<City> GetCityByParentId(int parentId, int skip, int take)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            List<City> cities = session.Query<City>()
                .Where(c => c.ParentId == parentId)
                .OrderBy(c => c.Name)
                .Skip(skip).Take(take).ToList();
            return cities;
        }
    }

    public bool IsThereATerritory(int parentId)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            int district = session.Query<City>()
                .Where(c => c.ParentId == parentId).Count();
            if(district > 0)
                return true;
            return false;
        }
    }

    public void MultipleDeletion(List<City> cities)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            foreach (City city in cities)
            {
                session.Delete(city);
            }
            session.Flush();
            session.Clear();
        }
    }
}
