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
            throw new NotImplementedException();
        }
    }
}
