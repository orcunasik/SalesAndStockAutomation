using NHibernate;

namespace SalesAndStockAutomation.Base.DB.Helper;

public abstract class NHibernateHelper : IDisposable
{
    private static ISessionFactory _sessionFactory;
    public virtual ISessionFactory SessionFactory => _sessionFactory ??= InitializeFactory();

    protected abstract ISessionFactory InitializeFactory();
    public virtual ISession OpenSession()
    {
        return SessionFactory.OpenSession();
    }
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}