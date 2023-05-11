using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class UserCart
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? TicketTypeId { get; set; }
}
