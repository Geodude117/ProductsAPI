﻿using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.DatabaseContext
{
    
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
