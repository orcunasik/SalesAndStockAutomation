using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Base.DB.Interface;
using SalesAndStockAutomation.Base.Entity;
using System.Linq.Expressions;

namespace SalesAndStockAutomation.Base.DB.Manager;

public class RepositoryService<T> : IRepositoryService<T> where T : class, IEntity, new()
{
    private NHibernateHelper _nHibernateHelper;

    public RepositoryService(NHibernateHelper nHibernateHelper)
    {
        _nHibernateHelper = nHibernateHelper;
    }

    public T Add(T entity)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            session.Save(entity);
            session.Flush();
            return entity;
        }
    }

    public void Delete(T entity)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            session.Delete(entity);
            session.Flush();
            session.Clear();
        }
    }

    public T Get(Expression<Func<T, bool>>? filter = null)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            return session.Query<T>().SingleOrDefault(filter);
        }
    }

    public List<T> GetList(Expression<Func<T, bool>>? filter = null)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            return filter is null 
                ? session.Query<T>().ToList()
                : session.Query<T>().Where(filter).ToList();
        }
    }

    public T Update(T entity)
    {
        using (var session = _nHibernateHelper.OpenSession())
        {
            session.Update(entity);
            session.Flush();
            return entity;
        }
    }
}
