using System;
using System.Collections.Generic;

namespace IMSApi.Models;

public partial class Owner
{
    public int OwnerId { get; set; }

    public int? AccessLevelId { get; set; }

    public int? CompanyId { get; set; }

    public string? Name { get; set; }

    public string? Identification { get; set; }

    public string? Phone { get; set; }

    public string? Mail { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
