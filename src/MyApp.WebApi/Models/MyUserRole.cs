using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class MyUserRole
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public string UserName { get; set; } = null!;

    public Guid? UserId { get; set; }
}
