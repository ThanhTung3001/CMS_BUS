using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class A1
{
    public int Id { get; set; }

    public virtual ICollection<A2> A2s { get; set; } = new List<A2>();
}
