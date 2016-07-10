using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
   public class Product
    {
        [Key]
        public virtual int ProductID { get; set; }

        [Required]
        public virtual string Name { get; set; }

        [Required]
        public virtual string Manifacturer { get; set; }

        public virtual bool isActive { get; set; }

        public virtual int UserID { get; set; }
        
        public virtual User User { get; set; }

        public virtual ICollection<OnlineStore> OnlineStores { get; set; }
        public virtual ICollection<ProductMatch> ProductMatches { get; set; }

    }
}
