using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class HbDoanhNghiep
{
    public byte Id { get; set; }

    public string? MaSoThue { get; set; }

    public string Ten { get; set; } = null!;

    public string? GioiThieu { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? HopThu { get; set; }

    public string? TrangChu { get; set; }

    public bool? HoatDong { get; set; }

    public virtual ICollection<HbBangGiaVe> HbBangGiaVes { get; set; } = new List<HbBangGiaVe>();

    public virtual ICollection<HbGopY> HbGopies { get; set; } = new List<HbGopY>();

    public virtual ICollection<HbXe> HbXes { get; set; } = new List<HbXe>();
}
