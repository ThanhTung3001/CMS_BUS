using System;
using System.Collections.Generic;

namespace MyApp.WebApi.Models;

public partial class Menu
{
    public int Id { get; set; }

    public int? ParentId { get; set; }

    public string Name { get; set; } = null!;

    public string? Icon { get; set; }

    public string IsActive { get; set; } = null!;

    public string? Path { get; set; }

    public int? DisplayOrder { get; set; }

    public string IsLeaf { get; set; } = null!;

    public string IsAdminTool { get; set; } = null!;
}
