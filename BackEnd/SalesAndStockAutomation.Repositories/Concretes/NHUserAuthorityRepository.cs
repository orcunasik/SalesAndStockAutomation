using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Base.DB.Manager;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;

namespace SalesAndStockAutomation.Repositories.Concretes;

public class NHUserAuthorityRepository : RepositoryService<UserAuthority>, IUserAuthorityRepository
{
    private NHibernateHelper _nHibernateHelper;
    public NHUserAuthorityRepository(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
    {
        _nHibernateHelper = nHibernateHelper;
    }

    public List<Employee> GetEmployeesByAuthorityId(int authorityId, int skip, int take)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            List<Employee> employees = session.Query<UserAuthority>() 
                .Where(u => u.Authority.Id == authorityId)
                .Select(u => u.Employee)
                .OrderBy(e => e.FirstName)
                .Skip(skip).Take(take).ToList();  
            return employees;
        }
    }
}
