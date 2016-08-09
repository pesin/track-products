using ProductsTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Lib
{
    public class Runner
    {
        private IRepository repository;
        public Runner() : this(RepositoryFactory.CreateRepository())
        {

        }

        public Runner(IRepository irepository)
        {
            this.repository = irepository;
        }
        public IEnumerable<ProductMatch> retrieveMatches(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");

            }

            List<ProductMatch> retval = new List<ProductMatch>();
            WebRetriever wb = new WebRetriever();
            foreach (var store in product.OnlineStores)
            {
                var matches = wb.getResults(product, store);
                retval.AddRange(matches);
                this.repository.ProductMatches.AddRange(matches);
            }

            return retval;
        }
    }
}
