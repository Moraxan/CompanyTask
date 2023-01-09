using Company.Data.Entities;
using Company.Data.Interfaces;
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
 new { lp.PositionId, lp.EmployeeId });

        //SeedData(builder);
    }
    private void SeedData(ModelBuilder builder)
    {
        var companyNames = new List<CompanyName>
        {
            new CompanyName {

                Id = 1,
                Company = "Corporate Data Sweden",
            },

            new CompanyName {
                Id = 2,
                Company = "Corporate Data Norway",

            },
                     {
            new CompanyName {
                Id = 3,
                Company = "Corporate Data Finland",
            }
            }

        };
        builder.Entity<CompanyName>().HasData(companyNames);

        var departments = new List<Department>
        {
            new Department {

                Id = 1,
                DepartmentName = "Office",
                CompanyId = 2,
                
            },

            new Department {
                Id = 2,
                DepartmentName = "Engineering",
                CompanyId = 1

            },
                     {
            new Department {
                Id = 3,
                DepartmentName = "Coding",
                CompanyId = 3
            }
            }

        };
        builder.Entity<Department>().HasData(departments);

        var employees = new List<Employee>
        {
            new Employee {

                Id = 1,
                FirstName = "Gösta",
                LastName = "Bernard",
                DepartmentId= 1,
                Salary = 50000,
                UnionAttached = false,
                
                
            },

            new Employee {
                Id = 2,
                FirstName = "Monika",
                LastName = "Zetterlund",
                DepartmentId= 2,
                Salary = 30000,
                UnionAttached = true,

            },
                     {
            new Employee {
               Id = 3,
                FirstName = "Svante",
                LastName = "Turesson",
                DepartmentId= 3,
                Salary = 30000,
                UnionAttached = false,
            }
            }

        };
        builder.Entity<Employee>().HasData(employees);

        var linkPositions = new List<LinkPosition>
        {
            new LinkPosition {

                EmployeeId= 3,
                PositionId= 1


            },

            new LinkPosition {
                EmployeeId= 2,
                PositionId= 3

            },
                     
            new LinkPosition {
                EmployeeId= 2,
                PositionId= 1
            },
            new LinkPosition {
                EmployeeId= 2,
                PositionId= 2
            }
            

        };
        builder.Entity<LinkPosition>().HasData(linkPositions);
    }
        

}
    


