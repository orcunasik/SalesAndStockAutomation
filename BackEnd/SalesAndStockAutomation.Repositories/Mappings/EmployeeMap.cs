using FluentNHibernate.Mapping;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Mappings;

public class EmployeeMap : ClassMap<Employee>
{
    public EmployeeMap()
    {
        Table("employees");
        Id(e => e.Id).Column("Id").GeneratedBy.Identity();
        Map(e => e.FirstName).Column("FirstName").CustomSqlType("varchar(30)");
        Map(e => e.LastName).Column("LastName").CustomSqlType("varchar(30)");
        Map(e => e.Email).Column("Email").CustomSqlType("varchar(50)");
        Map(e => e.PhoneNumber).Column("PhoneNumber").CustomSqlType("varchar(15)");
        Map(e => e.Address).Column("Address");
    }
}
