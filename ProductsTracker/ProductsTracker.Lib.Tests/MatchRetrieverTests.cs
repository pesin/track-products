using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            p = new Product()
            {
                isActive = true,
                Manifacturer = "f",
                Name = "Octopod",
                ProductID = 1,
                UserID = 1,
                 OnlineStores=new List<OnlineStore>()
            };
            repository.Products.Add(p);
        }

        [TestMethod()]
        public void retrieveMatchesTest()
        {
           
            mr.retrieveMatches(p);
            Assert.Inconclusive();
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