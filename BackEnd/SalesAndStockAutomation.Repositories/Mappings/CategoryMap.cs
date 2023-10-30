using FluentNHibernate.Mapping;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Mappings;

public class CategoryMap : ClassMap<Category>
{
    public CategoryMap()
    {
        Table("categories");
        Id(c => c.Id).Column("Id").GeneratedBy.Identity();
        Map(c => c.CategoryName).Column("CategoryName").CustomSqlType("varchar(30)");
    }
}
