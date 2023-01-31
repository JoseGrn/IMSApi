using System;
using System.Collections.Generic;

namespace IMSApi.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string? Name { get; set; }

    public string? Direction { get; set; }

    public string? Phone { get; set; }

    public string? Description { get; set; }

    public string? Mail { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<Owner> Owners { get; } = new List<Owner>();

    public virtual ICollection<Warehouse> Warehouses { get; } = new List<Warehouse>();
}
