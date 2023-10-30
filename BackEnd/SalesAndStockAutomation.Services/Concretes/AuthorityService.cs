using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class AuthorityService : IAuthorityService
{
    private IAuthorityRepository _repository;

    public AuthorityService(IAuthorityRepository repository)
    {
        _repository = repository;
    }

    public Authority Add(Authority entity)
    {
        return _repository.Add(entity);
    }

    public void Delete(Authority entity)
    {
        _repository.Delete(entity);
    }

    public List<Authority> GetAll()
    {
        return _repository.GetList();
    }

    public Authority GetAuthority(int id)
    {
        return _repository.Get(a => a.Id == id);
    }

    public Authority Update(Authority entity)
    {
        return _repository.Update(entity);
    }
}
