using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class HbGopY
{
    public int Id { get; set; }

    public byte? DoanhNghiepId { get; set; }

    public long? CustomerId { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? NgayGui { get; set; }

    public bool? TiepNhan { get; set; }

    public virtual HbCustomer? Customer { get; set; }

    public virtual HbDoanhNghiep? DoanhNghiep { get; set; }
}
