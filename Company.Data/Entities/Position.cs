using Company.Data.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities;

public class Position : IEntity
{
    public int id { get; set; }
    [MaxLength(50), Required]

    public string PositionName { get; set; }
    public int PositionID { get; set; }

    public virtual ICollection<Employee>? Employees { get; set; }

}
