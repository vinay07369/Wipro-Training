using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductWebApplicationJ3.Models;

namespace ProductWebApplicationJ3.Data
{
    public class ProductWebApplicationJ3Context : DbContext
    {
        public ProductWebApplicationJ3Context (DbContextOptions<ProductWebApplicationJ3Context> options)
            : base(options)
        {
        }

        public DbSet<ProductWebApplicationJ3.Models.Product> Product { get; set; } = default!;
    }
}
