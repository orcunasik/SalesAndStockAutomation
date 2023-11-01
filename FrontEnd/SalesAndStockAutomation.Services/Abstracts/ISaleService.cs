using SalesAndStockAutomation.Models.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface ISaleService
{
    Task<List<Sale>> GetAllAsync();
    Task<List<Sale>> PagingAsync(int skip, int take);
    Task<Sale> GetByIdAsync(int id);
    Task<Sale> AddAsync(Sale entity);
    Task<Sale> UpdateAsync(Sale entity);
    void Delete(int id);
}
