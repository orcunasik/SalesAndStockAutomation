using FluentNHibernate.Mapping;
using SalesAndStockAutomation.Entities.Entities;

namespace SalesAndStockAutomation.Repositories.Mappings;

public class SaleMap : ClassMap<Sale>
{
    public SaleMap()
    {
        Table("sales");
        Id(s => s.Id).Column("Id").GeneratedBy.Identity();
        Map(s => s.Quantity).Column("Quantity");
        Map(s => s.SaleDate).Column("SaleDate");

        References(s => s.Product).Column("ProductId").Not.LazyLoad();
        References(s => s.Customer).Column("CustomerId").Not.LazyLoad();
        References(s => s.Employee).Column("EmployeeId").Not.LazyLoad();
    }
}
