using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class Service
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string PriceDescription { get; set; } = null!;

    public int? VideoId { get; set; }

    public int? ImageId { get; set; }
}
