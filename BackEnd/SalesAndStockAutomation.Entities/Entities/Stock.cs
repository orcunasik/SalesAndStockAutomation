using SalesAndStockAutomation.Base.Entity;

namespace SalesAndStockAutomation.Entities.Entities;

public class Stock : IEntity
{
    public virtual int Id { get; set; }
    public virtual Product Product { get; set; }
    public virtual Employee Employee { get; set; }
    public virtual DateTime CreatedDate { get; set; }
    public virtual int Quantity { get; set; }
}
