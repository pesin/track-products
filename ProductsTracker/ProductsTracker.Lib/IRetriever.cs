using ProductsTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductsTracker.Lib
{
    interface IRetriever
    {
        IEnumerable<ProductMatch> getResults(Product product, Store store);
    }
}
