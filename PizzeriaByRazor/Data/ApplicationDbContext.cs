﻿using Microsoft.EntityFrameworkCore;
using PizzeriaByRazor.Models;

namespace PizzeriaByRazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders{ get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
