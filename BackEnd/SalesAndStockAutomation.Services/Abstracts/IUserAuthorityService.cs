using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface IUserAuthorityService
{
    List<UserAuthority> GetAll();
    List<Employee> GetEmployeesByAuthorityId(int authorityId, int skip, int take);
    UserAuthority GetById(int id);
    UserAuthority Add(UserAuthority entity);
    UserAuthority Update(UserAuthority entity);
    void Delete(UserAuthority entity);
}
