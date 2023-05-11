using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class A2
{
    public int Id { get; set; }

    public virtual ICollection<A1> A1s { get; set; } = new List<A1>();
}
