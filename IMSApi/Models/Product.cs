using System;
using System.Collections.Generic;

namespace IMSApi.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public int? WarehouseId { get; set; }

    public string? Name { get; set; }

    public int? Quantity { get; set; }

    public string? Description { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
