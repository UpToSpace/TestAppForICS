using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using TestApp.Models;

namespace TestApp
{
    public class EmployeesDB : DbContext
    {
        public EmployeesDB()
            : base("name=EmployeesDB")
        {
        }

        public virtual DbSet<Employee> Employees
        {
            get;
            set;
        }
    }
}