using ProductsTracker.Data.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
    public class Repository : IRepository
    {
        private DataContext dataContext;

        internal Repository()
        {
            dataContext = new DataContext();
        }

        public DbSet<User> Users
        {
            get
            {
                return this.dataContext.Users;
            }
        }


        public DbSet<OnlineStore> OnlineStores
        {
            get
            {
                return this.dataContext.OnlineStores;
            }
        }
        public DbSet<Product> Products
        {
            get
            {
                return this.dataContext.Products;
            }
        }
        public DbSet<Store> Stores
        {
            get
            {
                return this.dataContext.Stores;
            }
        }
        public DbSet<ProductMatch> ProductMatches
        {
            get
            {
                return this.dataContext.ProductMatches;
            }
        }

    }
}
