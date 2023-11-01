using SalesAndStockAutomation.Models.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface IAuthorityService
{
    Task<List<Authority>> GetAllAsync();
    Task<Authority> GetAuthorityAsync(int  id);
    Task<Authority> AddAsync(Authority entity);
    Task<Authority> UpdateAsync(Authority entity);
    void Delete(int id);
}
