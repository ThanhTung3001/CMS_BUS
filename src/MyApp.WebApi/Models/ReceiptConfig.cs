using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class ReceiptConfig
{
    public int Id { get; set; }

    public string TaiKhoanPhatHanh { get; set; } = null!;

    public string MatKhauPhatHanh { get; set; } = null!;

    public string TaiKhoanDichVu { get; set; } = null!;

    public string MatKhauDichVu { get; set; } = null!;

    public string PublishServiceUrl { get; set; } = null!;

    public string PortalServiceUrl { get; set; } = null!;

    public string BusinessServiceUrl { get; set; } = null!;
}
