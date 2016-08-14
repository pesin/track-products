using ProductsTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Lib
{
   public class ProductService
    {
        private IRepository repository { get; set; }

        internal ProductService(IRepository repo)
        {
            this.repository = repo;
        }

        public ProductService() : this(RepositoryFactory.CreateRepository())
        {

        }

        public IEnumerable<Product> GetProductsForUser(int userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ProductMatch> GetProductMatches(int userId)
        {
            throw new NotImplementedException();
        }


    }
}
