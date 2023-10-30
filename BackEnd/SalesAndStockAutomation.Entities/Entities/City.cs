using SalesAndStockAutomation.Base.Entity;

namespace SalesAndStockAutomation.Entities.Entities;

public class City : IEntity
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
    public virtual int ParentId { get; set; }
}
