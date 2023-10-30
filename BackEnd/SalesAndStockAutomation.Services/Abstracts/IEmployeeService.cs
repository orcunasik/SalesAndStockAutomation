using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Services.Abstracts;

public interface IEmployeeService
{
    List<Employee> GetAll();
    Employee GetById(int id);
    Employee Add(Employee entity);
    Employee Update(Employee entity);
    void Delete(Employee entity);
}
