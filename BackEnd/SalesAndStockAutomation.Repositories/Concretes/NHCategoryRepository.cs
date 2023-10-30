using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Base.DB.Manager;
using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;

namespace SalesAndStockAutomation.Repositories.Concretes;

public class NHCategoryRepository : RepositoryService<Category>, ICategoryRepository
{
    private NHibernateHelper _nHibernateHelper;
    public NHCategoryRepository(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
    {
        _nHibernateHelper = nHibernateHelper;
    }

    public List<Category> Paging(int skip, int take)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            List<Category> categories = session.Query<Category>()
                .OrderBy(c => c.CategoryName)
                .Skip(skip).Take(take).ToList();
            return categories;
        }
    }
}
