﻿using SalesAndStockAutomation.Base.Entity;

namespace SalesAndStockAutomation.Entities.Entities;

public class Customer : IEntity
{
    public virtual int Id { get; set; }
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }
    public virtual string PhoneNumber { get; set; }
    public virtual string Address { get; set; }
    public virtual City City { get; set; }

}
