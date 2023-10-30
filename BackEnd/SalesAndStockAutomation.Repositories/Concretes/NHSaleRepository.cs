using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Base.DB.Manager;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;

namespace SalesAndStockAutomation.Repositories.Concretes;

public class NHSaleRepository : RepositoryService<Sale>, ISaleRepository
{
    private NHibernateHelper _nHibernateHelper;
    public NHSaleRepository(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
    {
        _nHibernateHelper = nHibernateHelper;
    }

    public List<Sale> Paging(int skip, int take)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            List<Sale> sales = session.Query<Sale>()
                .OrderByDescending(s => s.Id)
                .Skip(skip).Take(take).ToList();
            return sales;
        }
    }
}
