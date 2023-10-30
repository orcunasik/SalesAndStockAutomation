using SalesAndStockAutomation.Base.Entity;

namespace SalesAndStockAutomation.Entities.Entities;

public class Sale : IEntity
{
    public virtual int Id { get; set; }
    public virtual Product Product { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual Employee Employee { get; set; }
    public virtual DateTime SaleDate { get; set; }
    public virtual int Quantity { get; set; }
}
