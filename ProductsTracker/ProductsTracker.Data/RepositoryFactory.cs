using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
  public static  class RepositoryFactory
    {
        public static IRepository CreateRepository()
        {
            return new Repository();
        }
    }
}
