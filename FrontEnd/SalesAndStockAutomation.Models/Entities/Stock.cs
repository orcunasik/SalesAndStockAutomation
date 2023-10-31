namespace SalesAndStockAutomation.Models.Entities;

public class Stock
{
    public virtual int Id { get; set; }
    public virtual Product Product { get; set; }
    public virtual Employee Employee { get; set; }
    public virtual DateTime CreatedDate { get; set; }
    public virtual int Quantity { get; set; }
}
