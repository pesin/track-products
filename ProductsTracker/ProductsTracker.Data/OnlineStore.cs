using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
 public   class OnlineStore: IStore
    {
        [Key]
        public virtual int OnlineStoreID { get; set; }

        [Required]
        public virtual string Name { get; set; }

        [Required]
        public virtual string SearchURL { get; set; }

        [Required]
        public virtual string ProductRegex { get; set; }

        [Required]
        public virtual string PriceRegex { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
