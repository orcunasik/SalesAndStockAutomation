namespace SalesAndStockAutomation.Models.Entities;

public class UserAuthority
{
    public virtual int Id { get; set; }
    public virtual string Password { get; set; }
    public virtual Authority Authority { get; set; }
    public virtual Employee Employee { get; set; }
}
