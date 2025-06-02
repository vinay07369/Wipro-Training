using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeWebApplicationJ2.Models;

namespace EmployeeWebApplicationJ2.Data
{
    public class EmployeeWebApplicationJ2Context : DbContext
    {
        public EmployeeWebApplicationJ2Context (DbContextOptions<EmployeeWebApplicationJ2Context> options)
            : base(options)
        {
        }

        public DbSet<EmployeeWebApplicationJ2.Models.Employee> Employee { get; set; } = default!;
    }
}
