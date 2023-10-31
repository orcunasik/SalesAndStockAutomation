namespace SalesAndStockAutomation.Models.Entities;

public class City
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual int ParentId { get; set; }
}
