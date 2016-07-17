using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
    public interface IRepository
    {
        DbSet<User> Users
        {
            get;

        }


        DbSet<OnlineStore> OnlineStores
        {
            get;

        }
        DbSet<Product> Products
        {
            get;

        }
        DbSet<Store> Stores
        {
            get;

        }
        DbSet<ProductMatch> ProductMatches
        {
            get;

        }
    }
}
