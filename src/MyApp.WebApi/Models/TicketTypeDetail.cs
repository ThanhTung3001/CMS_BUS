﻿using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class TicketTypeDetail
{
    public int Id { get; set; }

    public int? PlaceId { get; set; }

    public int TicketTypeId { get; set; }
}
