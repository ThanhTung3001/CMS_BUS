using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class ReceiptTemplateConfig
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string IsActive { get; set; } = null!;
}
