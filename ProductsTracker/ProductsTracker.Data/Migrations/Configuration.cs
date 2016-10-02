namespace ProductsTracker.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductsTracker.Data.DAL.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }


        private void LookupDataInit(DAL.DataContext context)
        {
            var rules = new List<ParserRule>()
            {
                new ParserRule()
                {
                   
                    type=ParserRuleType.ProductContainer,
                    XPath = @"//a[contains(@id,'product')]"
                },
                 new ParserRule()
                {
                   
                    type=ParserRuleType.ProductContainer,
                    XPath = @"//a[contains(@id,'result')]"
                },
                  new ParserRule()
                {

                    type=ParserRuleType.ProductContainer,
                    XPath = @"//a[contains(@class,'product')]"
                },
                new ParserRule()
                {

                    type=ParserRuleType.ProductContainer,
                    XPath = @"//a[contains(@id,'product')]"
                },
            };
        }

        protected override void Seed(ProductsTracker.Data.DAL.DataContext context)
        {
            //  This method will be called after migrating to the latest version.
            var users = new List<User>
            {
            new User{Name="Pesin",UserID=1}
            };

            users.ForEach(s => context.Users.AddOrUpdate(s));
            context.SaveChanges();
            var stores = new List<OnlineStore>
            {
            new OnlineStore{ID=1,Name="amazon.ca search", SearchURL="https://www.amazon.ca/s/ref=nb_sb_noss_1?url=search-alias%3Daps&field-keywords={0}",
            Regex="<li id=\"result_.*?<div class=\"a-fixed-left-grid\">.*?<a.*?href=\"(?<url>.*?)\">.*?<h2[^>]*?>(?<name>[^<]*?)</h2>.*?<span class=\"a-size-base a-color-price s-price a-text-bold\">(?<price>[^<]*?)</span>",
                PriceRegexGroupName ="${price}",
                ProductRegexGroupName ="${name}",
                ProductURLRegexGroupName ="${url}",
            PriceRegexCurrencyName="CAD"},

            new OnlineStore {
                ID =2,
                Name ="vertbaudet boy search",
                SearchURL ="http://www.vertbaudet.com/En/boy/search={0}.htm",
                Regex="{[^}]*?\"list_product_currency\": \"(?<currency>[^\"]*?)\"[^}]*?list_product_currentprice_ati\": (?<price>[^,]*?),[^}]*?list_product_id\": \"({n}??<url>[^\"]*?)\"[^}]*?list_product_name\": \"(?<name>[^\"]*?)\"[^}]*?}",
                PriceRegexGroupName="${price}",
                ProductRegexGroupName="${name}",
                ProductURLRegexGroupName="http://www.vertbaudet.com/En/search=${url}.htm",
                PriceRegexCurrencyName="${currency}"

            }
            };
            stores.ForEach(s => context.OnlineStores.AddOrUpdate(s));
            context.SaveChanges();
            var products = new List<Product>
            {
            new Product{ProductID=1,UserID=1,Name="Octonauts Gup-K",Manifacturer="Fisher-Price",isActive=true},
            new Product{ProductID=2,UserID=1,Name="bathrobe",Manifacturer="Vertbaudet",isActive=true},
            };
            products.ForEach(s => context.Products.AddOrUpdate(s));
            context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
