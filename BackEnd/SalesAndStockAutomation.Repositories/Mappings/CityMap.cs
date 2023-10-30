using FluentNHibernate.Mapping;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Mappings;

public class CityMap : ClassMap<City>
{
    public CityMap()
    {
        Table("cities");
        Id(c => c.Id).Column("Id").GeneratedBy.Identity();
        Map(c=> c.Name).Column("Name").CustomSqlType("varchar(30)");
        Map(c => c.ParentId).Column("ParentId");
    }
}
