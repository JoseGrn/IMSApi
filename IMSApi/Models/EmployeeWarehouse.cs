using System;
using System.Collections.Generic;

namespace IMSApi.Models;

public partial class EmployeeWarehouse
{
    public int EmployeeWarehouseId { get; set; }

    public int? EmployeeId { get; set; }

    public int? WarehouseId { get; set; }
}
