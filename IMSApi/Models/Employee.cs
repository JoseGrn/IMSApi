using System;
using System.Collections.Generic;

namespace IMSApi.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public int? AccessLevelId { get; set; }

    public int? CompanyId { get; set; }

    public int? OwnerId { get; set; }

    public string? Name { get; set; }

    public string? Identification { get; set; }

    public string? Phone { get; set; }

    public string? Mail { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<EmployeeWarehouse> EmployeeWarehouses { get; } = new List<EmployeeWarehouse>();
}
