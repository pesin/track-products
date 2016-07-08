using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
 public   class OnlineStore: Store
    {
        [Required]
        public virtual string SearchURL { get; set; }

        [Required]
        public virtual string ProductRegex { get; set; }

        [Required]
        public virtual string PriceRegex { get; set; }

        
    }
}
