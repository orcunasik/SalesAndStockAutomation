using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Base.DB.Manager;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;

namespace SalesAndStockAutomation.Repositories.Concretes;

public class NHCustomerRepository : RepositoryService<Customer>, ICustomerRepository
{
    private NHibernateHelper _nHibernateHelper;
    public NHCustomerRepository(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
    {
        _nHibernateHelper = nHibernateHelper;
    }

    public List<Customer> Paging(int skip, int take)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            List<Customer> customers = session.Query<Customer>()
                .OrderBy(c => c.FirstName)
                .Skip(skip).Take(take).ToList();
            return customers;
        }
    }
}
