using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Base.DB.Manager;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;

namespace SalesAndStockAutomation.Repositories.Concretes;

public class NHEmployeeRepository : RepositoryService<Employee>, IEmployeeRepository
{
    private NHibernateHelper _nHibernateHelper;
    public NHEmployeeRepository(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
    {
        _nHibernateHelper = nHibernateHelper;
    }
}
