using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dokan.Models;
using Microsoft.EntityFrameworkCore;

namespace Dokan.Persistence
{
    public class DokanDbContext:DbContext
    {
        public DokanDbContext(DbContextOptions<DokanDbContext> options):base(options)
        {
                
        }
        public DbSet<Inventory> inventories { get; set; }
        public DbSet <Bill> FactorRecords { get; set; }
        public DbSet <Factor> Factors  { get; set; }
        public DbSet <MeToYouCustomer> Customers { get; set; }
        public DbSet <Phone> Phones { get; set; }
        public DbSet <MeToYouSales> MeToYouSales { get; set; }
        public DbSet<RecivedMeToYou> Incomings { get; set; }



    }
}
