using System;
using System.Collections.Generic;

namespace IMSApi.Models;

public partial class AccessLevel
{
    public int AccessLevelId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<Owner> Owners { get; } = new List<Owner>();
}
