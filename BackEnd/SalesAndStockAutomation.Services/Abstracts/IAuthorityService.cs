using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface IAuthorityService
{
    List<Authority> GetAll();
    Authority GetAuthority(int  id);
    Authority Add(Authority entity);
    Authority Update(Authority entity);
    void Delete(Authority entity);
}
