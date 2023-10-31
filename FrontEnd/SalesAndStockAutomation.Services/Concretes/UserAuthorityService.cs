using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class UserAuthorityService : IUserAuthorityService
{
    public Task<UserAuthority> AddAsync(UserAuthority entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(UserAuthority entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<UserAuthority>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserAuthority> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Employee>> GetEmployeesByAuthorityIdAsync(int authorityId, int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<UserAuthority> UpdateAsync(UserAuthority entity)
    {
        throw new NotImplementedException();
    }
}
