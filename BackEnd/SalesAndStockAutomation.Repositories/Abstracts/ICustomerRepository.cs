using SalesAndStockAutomation.Base.DB.Interface;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Abstracts
{
    public interface ICustomerRepository : IRepositoryService<Customer>
    {
        List<Customer> Paging(int skip, int take);
    }
}
