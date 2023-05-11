using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class HbDiem
{
    public short Id { get; set; }

    public string? SoHieu { get; set; }

    public string DiaDiem { get; set; } = null!;

    public bool? HoatDong { get; set; }

    public virtual ICollection<HbNhatKy> HbNhatKies { get; set; } = new List<HbNhatKy>();

    public virtual ICollection<HbTuyenDiem> HbTuyenDiems { get; set; } = new List<HbTuyenDiem>();
}
