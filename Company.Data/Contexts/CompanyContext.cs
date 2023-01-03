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
    public DbSet<CompanyName> CompanyNames => Set<CompanyName>();
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<LinkPosition> LinkPositions => Set<LinkPosition>();
    public DbSet<Position> Positions => Set<Position>();
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

