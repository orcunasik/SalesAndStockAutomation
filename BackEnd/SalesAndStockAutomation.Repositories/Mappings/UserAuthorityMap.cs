using FluentNHibernate.Mapping;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Mappings;

public class UserAuthorityMap : ClassMap<UserAuthority>
{
    public UserAuthorityMap()
    {
        Table("userAuthorities");
        Id(ua => ua.Id).Column("Id").GeneratedBy.Identity();
        Map(ua => ua.Password).Column("Password");

        References(ua => ua.Employee).Column("EmployeeId").Not.LazyLoad();
        References(ua => ua.Authority).Column("AuthorityId").Not.LazyLoad();
    }
}
