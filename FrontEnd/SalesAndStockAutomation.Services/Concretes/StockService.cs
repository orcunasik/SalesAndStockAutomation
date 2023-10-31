using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class StockService : IStockService
{
    public Task<Stock> AddAsync(Stock entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Stock entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Stock>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Stock> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Stock>> PagingAsync(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<Stock> UpdateAsync(Stock entity)
    {
        throw new NotImplementedException();
    }
}
