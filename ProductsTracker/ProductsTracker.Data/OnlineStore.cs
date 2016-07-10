using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
 public class OnlineStore: Store
    {
        [Required]
        public virtual string SearchURL { get; set; }

        [Required]
        public virtual string Regex { get; set; }
        [Required]
        public virtual string ProductRegexGroupName { get; set; }

        [Required]
        public virtual string ProductURLRegexGroupName { get; set; }

        [Required]
        public virtual string PriceRegexGroupName { get; set; }

       
        public virtual string PriceRegexCurrencyName { get; set; }

        public override IEnumerable<ProductMatch> retrieveMatches()
        {
            throw new NotImplementedException();
        }
    }
}
