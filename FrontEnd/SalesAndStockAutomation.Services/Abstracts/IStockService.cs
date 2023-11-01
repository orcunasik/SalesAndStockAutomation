using SalesAndStockAutomation.Models.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface IStockService
{
    Task<List<Stock>> GetAllAsync();
    Task<List<Stock>> PagingAsync(int skip, int take);
    Task<Stock> GetByIdAsync(int id);
    Task<Stock> AddAsync(Stock entity);
    Task<Stock> UpdateAsync(Stock entity);
    void Delete(int id);
}
