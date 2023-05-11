using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class HbCustomer
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int UpdateById { get; set; }

    public DateTime UpdateTime { get; set; }

    public string CreatedById { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<HbCart> HbCarts { get; set; } = new List<HbCart>();

    public virtual ICollection<HbGopY> HbGopies { get; set; } = new List<HbGopY>();
}
