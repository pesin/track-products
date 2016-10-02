using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsTracker.Data;
using HtmlAgilityPack;

namespace ProductsTracker.Lib
{
 public   class HtmlParser : IParser
    {
        public IEnumerable<ProductMatch> parseProduct(string htmlSource)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(htmlSource);

            //id or class results 
            doc.DocumentNode.SelectNodes("//a[@href]")
        }

        public IEnumerable<ProductMatch> parseProducts(string htmlSource)
        {
            throw new NotImplementedException();
        }
    }
}
