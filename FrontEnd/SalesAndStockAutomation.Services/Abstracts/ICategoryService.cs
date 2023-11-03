using SalesAndStockAutomation.Models.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface ICategoryService
{
    Task<List<Category>> GetAllAsync();
    Task<List<Category>> PagingAsync(int skip, int take);
    Task<Category> GetByIdAsync(int id);
    Task<Category> AddAsync(Category entity);
    Task<Category> UpdateAsync(Category entity);
    Task<bool> DeleteAsync(int id);
}
