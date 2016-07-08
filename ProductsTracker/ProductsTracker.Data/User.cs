using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
    public class User
    {
        [Key]
        public virtual int UserID { get; set; }

        [Required]
        public virtual string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
