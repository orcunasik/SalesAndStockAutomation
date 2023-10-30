using SalesAndStockAutomation.Base.Entity;

namespace SalesAndStockAutomation.Entities.Entities;

public class UserAuthority : IEntity
{
    public virtual int Id { get; set; }
    public virtual string Password { get; set; }
    public virtual Authority Authority { get; set; }
    public virtual Employee Employee { get; set; }
}
