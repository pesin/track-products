using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data.Fakes
{

    public class FakeDBSet<TEntity>: DbSet<TEntity> where TEntity : class
    {
        private List<TEntity> list;
        
        public FakeDBSet()
        {
            this.list = new List<TEntity>();
        }

        public override TEntity Add(TEntity entity)
        {
            return base.Add(entity);
        }

        public override TEntity Create()
        {
            return base.Create();
        }

        public override TEntity Remove(TEntity entity)
        {
            return base.Remove(entity);
        }

       
    }
    public class FakeRepository : IRepository
    {
        private FakeDBSet<OnlineStore> onlineStores = new FakeDBSet<OnlineStore>();
        private FakeDBSet<Product> products = new FakeDBSet<Product>();
        private FakeDBSet<ProductMatch> productMatches = new FakeDBSet<ProductMatch>();
        private FakeDBSet<User> users = new FakeDBSet<User>();


        public DbSet<OnlineStore> OnlineStores
        {
            get
            {
               return this.onlineStores;
            }
        }

        public DbSet<ProductMatch> ProductMatches
        {
            get
            {
                return this.productMatches;
            }
        }

        public DbSet<Product> Products
        {
            get
            {
                return this.products;
            }
        }

        public DbSet<Store> Stores
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public DbSet<User> Users
        {
            get
            {
              return  this.users;
            }
        }
    }
}
