using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
    public abstract class Store
    {
        public int ID { get; set; }
        [Required]
        public  string Name { get; set; }

        public  ICollection<Product> Products { get; set; }

        public abstract IEnumerable<ProductMatch> retrieveMatches();
    }
}
