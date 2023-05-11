using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class HbTuyen
{
    public byte Id { get; set; }

    public string SoHieu { get; set; } = null!;

    public string TenTuyen { get; set; } = null!;

    public string? MoTa { get; set; }

    public string? DiemDau { get; set; }

    public string? DiemCuoi { get; set; }

    public decimal? CuLy { get; set; }

    public string? KhungGio { get; set; }

    public string? TanSuat { get; set; }

    public byte? SoChuyen { get; set; }

    public bool? HoatDong { get; set; }

    public int? SoLuotThich { get; set; }

    public virtual ICollection<HbBangGiaVe> HbBangGiaVes { get; set; } = new List<HbBangGiaVe>();

    public virtual ICollection<HbLichTrinh> HbLichTrinhs { get; set; } = new List<HbLichTrinh>();

    public virtual ICollection<HbTuyenDiem> HbTuyenDiems { get; set; } = new List<HbTuyenDiem>();
}
