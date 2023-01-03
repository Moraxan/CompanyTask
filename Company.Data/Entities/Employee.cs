﻿using Company.Data.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities;

public class Employee : IEntity
{
    public int id { get ; set ; }
    [MaxLength(50),Required]
    public string FirstName { get ; set ; }
    [MaxLength(50), Required]
    public string LastName { get; set ; }
    [MaxLength(50), Required]
    public int DepartmentId { get; set; }

    public int Salary { get; set; }
    public bool UnionAttached { get; set; }

    public virtual ICollection<Position>? Positions { get; set; }


}
