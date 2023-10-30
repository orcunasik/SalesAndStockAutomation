using FluentNHibernate.Mapping;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Mappings;

public class CustomerMap : ClassMap<Customer>
{
    public CustomerMap()
    {
        Table("customers");
        Id(c => c.Id).Column("Id").GeneratedBy.Identity();
        Map(c => c.FirstName).Column("FirstName").CustomSqlType("varchar(30)");
        Map(c => c.LastName).Column("LastName").CustomSqlType("varchar(30)");
        Map(c => c.PhoneNumber).Column("PhoneNumber").CustomSqlType("varchar(15)");
        Map(c => c.Address).Column("Address");

        References(c => c.City).Column("CityId").Not.LazyLoad();
    }
}
