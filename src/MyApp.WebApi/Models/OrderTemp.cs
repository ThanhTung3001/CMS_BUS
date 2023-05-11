using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class OrderTemp
{
    public string Id { get; set; } = null!;

    public decimal TotalPrice { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? UniqId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string IsForeign { get; set; } = null!;

    public string? OrderTime { get; set; }

    public short? Serial { get; set; }

    public int? CounterId { get; set; }

    public string IsSell { get; set; } = null!;

    public string? Remark { get; set; }

    public int? PrintType { get; set; }

    public string? IsUsePosMachine { get; set; }

    public string? TaxNumber { get; set; }

    public string? Address { get; set; }

    public string? CusCode { get; set; }
}
