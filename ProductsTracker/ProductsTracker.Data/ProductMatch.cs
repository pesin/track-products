using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
    public class ProductMatch
    {
        public virtual int ProductMatchID { get; set; }
        public virtual DateTime RetrievedOn { get; set; }
        public virtual double Price { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Product Product { get; set; }
        public virtual int ProductID { get; set; }


    }
}
