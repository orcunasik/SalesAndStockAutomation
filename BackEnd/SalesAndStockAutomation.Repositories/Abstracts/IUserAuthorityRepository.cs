using SalesAndStockAutomation.Base.DB.Interface;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Abstracts;

public interface IUserAuthorityRepository : IRepositoryService<UserAuthority>
{
    List<Employee> GetEmployeesByAuthorityId(int authorityId,int skip, int take);
}
