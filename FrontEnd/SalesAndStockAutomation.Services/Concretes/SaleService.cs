using SalesAndStockAutomation.Models.Entities;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class SaleService : ISaleService
{
    public Task<Sale> AddAsync(Sale entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Sale entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Sale>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Sale> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Sale>> PagingAsync(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public Task<Sale> UpdateAsync(Sale entity)
    {
        throw new NotImplementedException();
    }
}
