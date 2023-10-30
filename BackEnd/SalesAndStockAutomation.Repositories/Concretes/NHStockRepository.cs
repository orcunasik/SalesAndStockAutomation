using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Base.DB.Manager;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;

namespace SalesAndStockAutomation.Repositories.Concretes;

public class NHStockRepository : RepositoryService<Stock>, IStockRepository
{
    private NHibernateHelper _nHibernateHelper;
    public NHStockRepository(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
    {
        _nHibernateHelper = nHibernateHelper;
    }

    public List<Stock> Paging(int skip, int take)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            List<Stock> stocks = session.Query<Stock>()
                .OrderByDescending(s => s.CreatedDate)
                .Skip(skip).Take(take).ToList();
            return stocks;
        }
    }
}
