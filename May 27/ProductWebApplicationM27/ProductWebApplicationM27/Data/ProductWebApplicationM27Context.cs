using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductWebApplicationM27.Models;

namespace ProductWebApplicationM27.Data
{
    public class ProductWebApplicationM27Context : DbContext
    {
        public ProductWebApplicationM27Context (DbContextOptions<ProductWebApplicationM27Context> options)
            : base(options)
        {
        }

        public DbSet<ProductWebApplicationM27.Models.Product> Product { get; set; } = default!;
    }
}
