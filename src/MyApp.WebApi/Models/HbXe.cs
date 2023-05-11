using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class HbXe
{
    public short Id { get; set; }

    public byte? DoanhNghiepId { get; set; }

    public string BienSo { get; set; } = null!;

    public string NhanHieu { get; set; } = null!;

    public short? NamSanXuat { get; set; }

    public string? MauSon { get; set; }

    public string? SoMay { get; set; }

    public string? SoKhung { get; set; }

    public byte? SoGhe { get; set; }

    public string? TienNghi { get; set; }

    public DateTime? NgayLuuHanh { get; set; }

    public DateTime? NgayKiemDinh { get; set; }

    public bool? HoatDong { get; set; }

    public virtual HbDoanhNghiep? DoanhNghiep { get; set; }

    public virtual ICollection<HbLichTrinh> HbLichTrinhs { get; set; } = new List<HbLichTrinh>();

    public virtual ICollection<HbNhatKy> HbNhatKies { get; set; } = new List<HbNhatKy>();
}
