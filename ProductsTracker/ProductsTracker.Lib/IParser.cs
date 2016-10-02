using ProductsTracker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Lib
{
  public  interface IParser
    {
        IEnumerable<ProductMatch> parseProducts(string htmlSource);

        IEnumerable<ProductMatch> parseProduct(string htmlSource);

    }
}
