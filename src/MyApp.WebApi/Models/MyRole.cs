﻿using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class MyRole
{
    public int Id { get; set; }

    public string RoleName { get; set; } = null!;
}
