using FluentNHibernate.Mapping;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Mappings;

public class AuthorityMap : ClassMap<Authority>
{
    public AuthorityMap()
    {
        Table("authorities");
        Id(a => a.Id).Column("Id").GeneratedBy.Identity();
        Map(a => a.Name).Column("Name").CustomSqlType("varchar(30)");
    }
}
