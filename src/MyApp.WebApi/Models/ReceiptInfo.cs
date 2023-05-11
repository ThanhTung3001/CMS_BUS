﻿using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class ReceiptInfo
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? TaxNumber { get; set; }

    public string? Address { get; set; }

    public string? CusCode { get; set; }
}
