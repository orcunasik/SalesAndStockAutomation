using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Base.DB.Manager;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;

namespace SalesAndStockAutomation.Repositories.Concretes;

public class NHProductRepository : RepositoryService<Product>, IProductRepository
{
    private NHibernateHelper _nHibernateHelper;
    public NHProductRepository(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
    {
        _nHibernateHelper = nHibernateHelper;
    }

    public List<Product> GetProductsByCategoryId(int categoryId, int skip, int take)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            List<Product> products = session.Query<Product>().Where(p => p.Category.Id == categoryId)
                .OrderBy(p => p.Name)
                .Skip(skip).Take(take).ToList();
            return products;
        }
    }
}
