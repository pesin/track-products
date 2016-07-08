using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProductsTracker.Data.DAL
{
    public class DataContext : DbContext
    {

        public DataContext() : base("DataContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OnlineStore> OnlineStores { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

