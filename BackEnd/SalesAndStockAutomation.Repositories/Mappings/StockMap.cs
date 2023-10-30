using FluentNHibernate.Mapping;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Mappings;

public class StockMap : ClassMap<Stock>
{
    public StockMap()
    {
        Table("stocks");
        Id(s => s.Id).Column("Id").GeneratedBy.Identity();
        Map(s => s.Quantity).Column("Quantity");
        Map(s => s.CreatedDate).Column("CreatedDate");

        References(s => s.Product).Column("ProductId").Not.LazyLoad();
        References(s => s.Employee).Column("EmployeeId").Not.LazyLoad();
    }
}
