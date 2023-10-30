using FluentNHibernate.Mapping;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Mappings;

public class ProductMap : ClassMap<Product>
{
    public ProductMap()
    {
        Table("products");
        Id(p => p.Id).Column("Id").GeneratedBy.Identity();
        Map(p => p.Name).Column("Product").CustomSqlType("varchar(100)");
        Map(p => p.Price).Column("Price");
        Map(p => p.CreatedDate).Column("CreatedDate");

        References(p => p.Category).Column("CategoryId").Not.LazyLoad();
    }
}
