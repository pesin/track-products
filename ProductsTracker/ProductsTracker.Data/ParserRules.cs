using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Data
{
   public class ParserRule
    {


        [Key]
        public virtual int ParserRuleID { get; set; }

        [Required]
        public virtual string XPath { get; set; }

        [Required]
        public virtual ParserRuleType type { get; set; }

        //public virtual IEnumerable<string> Keywords { get; set; }

    }
   
    public enum ParserRuleType
    {
        ProductContainer=1,
        Image,
        Price,
        Currency,
        ProductLink
    }
}
