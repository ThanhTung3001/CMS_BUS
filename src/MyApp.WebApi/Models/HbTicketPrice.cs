using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class HbTicketPrice
{
    public int Id { get; set; }

    public int CustomerTypeId { get; set; }

    public int TiketTypeId { get; set; }

    public int Price { get; set; }

    public DateTime? CreatedTime { get; set; }

    public int? UpdateById { get; set; }

    public int? CreatedById { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? IsActive { get; set; }

    public virtual HbCustomerType CustomerType { get; set; } = null!;

    public virtual ICollection<HbBangGiaVe> HbBangGiaVes { get; set; } = new List<HbBangGiaVe>();

    public virtual ICollection<HbCartDetail> HbCartDetails { get; set; } = new List<HbCartDetail>();

    public virtual HbTicketType TiketType { get; set; } = null!;
}
