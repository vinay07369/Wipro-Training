using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeWebApp.Models;

namespace EmployeeWebApp.Data
{
    public class EmployeeWebAppContext : DbContext
    {
        public EmployeeWebAppContext (DbContextOptions<EmployeeWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeWebApp.Models.Employee> Employee { get; set; } = default!;
    }
}
