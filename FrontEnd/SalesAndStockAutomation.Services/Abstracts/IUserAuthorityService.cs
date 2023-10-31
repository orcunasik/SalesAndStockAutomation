using SalesAndStockAutomation.Models.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface IUserAuthorityService
{
    Task<List<UserAuthority>> GetAllAsync();
    Task<List<Employee>> GetEmployeesByAuthorityIdAsync(int authorityId, int skip, int take);
    Task<UserAuthority> GetByIdAsync(int id);
    Task<UserAuthority> AddAsync(UserAuthority entity);
    Task<UserAuthority> UpdateAsync(UserAuthority entity);
    void Delete(UserAuthority entity);
}
