using Company.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Company.Data.Contexts;

public class CompanyContext : DbContext
{
    public CompanyContext(DbContextOptions<CompanyContext> options)
: base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<LinkPosition>().HasKey(lp =>
 new { lp.PositionID, lp.EmployeeID });
    }
}

