using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication2_DepDsgEmp_1147.Models;

namespace WebApplication2_DepDsgEmp_1147.Data
{
    public class Applicationdbcontext:DbContext
    {
        public Applicationdbcontext() : base("conStr")
        { 
        }
        public  DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}