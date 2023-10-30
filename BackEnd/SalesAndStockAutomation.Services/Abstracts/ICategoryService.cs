using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface ICategoryService
{
    List<Category> GetAll();
    List<Category> Paging(int skip, int take);
    Category GetById(int id);
    Category Add(Category entity);
    Category Update(Category entity);
    void Delete(Category entity);
}
