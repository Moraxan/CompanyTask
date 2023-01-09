using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities;

public class Department : IEntity
{
    public int Id { get; set; }
    [MaxLength(50), Required]
    public string DepartmentName { get; set; }
    [MaxLength(50), Required]
    public int CompanyId { get; set; }

}
