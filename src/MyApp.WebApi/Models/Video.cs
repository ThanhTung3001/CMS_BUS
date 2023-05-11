﻿using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class Video
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public int? PlaceId { get; set; }

    public int? EventId { get; set; }

    public int? DaiNoiId { get; set; }

    public DateTime? CreatedTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? CreatedById { get; set; }

    public int? UpdateById { get; set; }
}
