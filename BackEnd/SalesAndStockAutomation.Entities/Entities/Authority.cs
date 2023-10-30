using SalesAndStockAutomation.Base.Entity;

namespace SalesAndStockAutomation.Entities.Entities;

public class Authority : IEntity
{
    public virtual int Id { get; set; }
    public virtual string Name { get; set; }
}
