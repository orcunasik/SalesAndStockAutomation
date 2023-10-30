using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes;

public class UserAuthorityService : IUserAuthorityService
{
    private IUserAuthorityRepository _repository;

    public UserAuthorityService(IUserAuthorityRepository repository)
    {
        _repository = repository;
    }

    public UserAuthority Add(UserAuthority entity)
    {
        return _repository.Add(entity);
    }

    public void Delete(UserAuthority entity)
    {
        _repository.Delete(entity);
    }

    public List<UserAuthority> GetAll()
    {
        return _repository.GetList();
    }

    public UserAuthority GetById(int id)
    {
        return _repository.Get(ua => ua.Id == id);
    }

    public List<Employee> GetEmployeesByAuthorityId(int authorityId, int skip, int take)
    {
        return _repository.GetEmployeesByAuthorityId(authorityId, skip, take);
    }

    public UserAuthority Update(UserAuthority entity)
    {
        return _repository.Update(entity);
    }
}
