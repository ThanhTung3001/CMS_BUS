using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class Role
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public int UpdateById { get; set; }

    public DateTime UpdateTime { get; set; }

    public int CreatedById { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
