using SalesAndStockAutomation.Base.Entity;

namespace SalesAndStockAutomation.Entities.Entities;

public class Category : IEntity
{
    public virtual int Id { get; set; }
    public virtual string CategoryName { get; set; }
}
