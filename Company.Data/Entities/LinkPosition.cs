﻿using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities;

public class LinkPosition : IReferenceEntity
{
    public int PositionID { get; set; }
    public int EmployeeID { get; set; } 

}
