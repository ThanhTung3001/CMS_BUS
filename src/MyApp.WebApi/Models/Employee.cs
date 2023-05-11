using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string? Description { get; set; }

    public int RoleId { get; set; }

    public int? UpdateById { get; set; }

    public int? CreatedById { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string UserName { get; set; } = null!;

    public string PassWord { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
