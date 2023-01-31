using System;
using System.Collections.Generic;

namespace IMSApi.Models;

public partial class Warehouse
{
    public int WarehouseId { get; set; }

    public int? CompanyId { get; set; }

    public string? Description { get; set; }

    public string? Direction { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<EmployeeWarehouse> EmployeeWarehouses { get; } = new List<EmployeeWarehouse>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
