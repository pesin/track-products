using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data.DAL
{
   public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var users = new List<User>
            {
            new User{Name="Pesin",UserID=1}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var stores = new List<OnlineStore>
            {
            new OnlineStore{OnlineStoreID=1,Name="amazon.ca", SearchURL="",PriceRegex="",ProductRegex=""}
            };
            stores.ForEach(s => context.OnlineStores.Add(s));
            context.SaveChanges();
            var products = new List<Product>
            {
            new Product{ProductID=1,UserID=1,Name="Octonauts Gup-K",Manifacturer="Fisher-Price",isActive=true},
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}
