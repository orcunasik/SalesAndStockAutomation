using SalesAndStockAutomation.Base.Entity;
using System.Linq.Expressions;

namespace SalesAndStockAutomation.Base.DB.Interface;

public interface IRepositoryService<T> where T : class, IEntity, new()
{
    List<T> GetList(Expression<Func<T,bool>>? filter = null);
    T Get(Expression<Func<T, bool>>? filter = null);
    T Add(T entity);
    T Update(T entity);
    void Delete(T entity);
}
