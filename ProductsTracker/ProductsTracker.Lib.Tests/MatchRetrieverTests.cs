using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ProductsTracker.Data;
using ProductsTracker.Data.Fakes;
using ProductsTracker.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsTracker.Lib.Tests
{
    [TestClass()]
    public class MatchRetrieverTests
    {
        Runner mr;
        Product p;
        FakeRepository repository;

        [TestInitialize]
       public void TestInit()
        {
            repository = new FakeRepository();
            mr = new Runner(repository);
            OnlineStore store = new OnlineStore()
            {
                ID = 1,
                Name = "amazon",
                Regex = @".*",
                PriceRegexCurrencyName = "a",
                PriceRegexGroupName = "b",
                ProductRegexGroupName = "c",
                ProductURLRegexGroupName = "w",
                SearchURL = "aaaaaaa",
                Products = new List<Product>()
            };
            repository.OnlineStores.Add(store);

            p = new Product()
            {
                isActive = true,
                Manifacturer = "f",
                Name = "Octopod",
                ProductID = 1,
                UserID = 1,
                 OnlineStores=new List<OnlineStore>()
            };

            p.OnlineStores.Add(store);
            store.Products.Add(p);
            repository.Products.Add(p);
            List<ProductMatch> matches = new List<ProductMatch>();
            matches.Add(new ProductMatch()
            {
                Currency = Currency.CAD,
                RetrievedOn = DateTime.Now,
                MatchedName = "octopod",
                MatchURL = "aa",
                Price = 40.0,
                Product = p,
                ProductID = p.ProductID,
                ProductMatchID = 1
            });
            var mock = new Mock<IRetriever>();
            mock.Setup(foo => foo.getResults(p,store)).Returns(matches);
        }

        [TestMethod()]
        public void retrieveMatchesTest()
        {
           
          var actual=  mr.retrieveMatches(p);
            Assert.AreEqual(1,actual.Count());
        }

        [TestMethod()]
        [ExpectedException(typeof( ArgumentNullException))]
        public void retrieveMatchesProductIsNullTest()
        {

            mr.retrieveMatches(null);
           
        }


        [TestMethod()]
        public void retrieveMatchesNoStoresTest()
        {

          var matches=  mr.retrieveMatches(p);
            Assert.AreEqual(0,matches.Count());
        }
    }
}