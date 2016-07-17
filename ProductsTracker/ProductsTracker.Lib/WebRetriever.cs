using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using ProductsTracker.Data;
using System.Net;
using System.IO;
using NLog;
using System.Text.RegularExpressions;

namespace ProductsTracker.Lib
{
    class WebRetriever : IRetriever
    {
        public IEnumerable<ProductMatch> getResults(Product product, Store store)
        {
            if (!(store is OnlineStore))
            {
                throw new NotImplementedException();
            }
            OnlineStore oStore = (OnlineStore)store;
            //create web request
            HttpWebRequest request = WebRequest.CreateHttp(oStore.buildRequestURL(product));
            request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.106 Safari/537.36";
            //get response
            WebResponse response = null;
            try
            {
                response = request.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    //parse
                    Regex regex = new Regex( oStore.Regex);
                }

            }
            catch(Exception e)
            {
                (new LogFactory()).GetLogger(this.GetType().ToString()).Error( e, oStore.ToString());
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
        }
    }
}
