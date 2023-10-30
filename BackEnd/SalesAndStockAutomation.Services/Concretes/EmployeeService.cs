using SalesAndStockAutomation.Entities.Entities;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Services.Abstracts;

namespace SalesAndStockAutomation.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public Employee Add(Employee entity)
        {
            return _repository.Add(entity);
        }

        public void Delete(Employee entity)
        {
            _repository.Delete(entity);
        }

        public List<Employee> GetAll()
        {
            return _repository.GetList();
        }

        public Employee GetById(int id)
        {
            return _repository.Get(e => e.Id == id);
        }

        public Employee Update(Employee entity)
        {
            return _repository.Update(entity);
        }
    }
}
