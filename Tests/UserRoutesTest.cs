using challenge_mvc_asp.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using MvcContrib.TestHelper;
using System.Web.Mvc;
using challenge_mvc_asp.Models;

namespace challenge_mvc_asp.Tests
{
    [TestFixture]
    public class UserRoutesTest
    {
        [TestFixtureSetUp]
        public void Setup()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        [Test]
        public void HomeIndex()
        {
            "~/".ShouldMapTo<HomeController>(a => a.Index());
            "~/Home".ShouldMapTo<HomeController>(a => a.Index());
            "~/Home/Index".ShouldMapTo<HomeController>(a => a.Index());
        }

        [Test]
        public void HomePage()
        {
            "~/Home/Page/1".ShouldMapTo<HomeController>(a => a.Page(1));
        }

        [Test]
        public void HomeDeal()
        {
            "~/summer-deal".ShouldMapTo<HomeController>(a => a.Deal());
        }

        [Test]
        public void NewsIndex()
        {
            "~/News".ShouldMapTo<NewsController>(a => a.Index());
            "~/News/Index".ShouldMapTo<NewsController>(a => a.Index());
        }

        [Test]
        public void NewsSearch()
        {
            "~/News/Search"
                .WithMethod(HttpVerbs.Post)
                .ShouldMapTo<NewsController>(a => 
                    a.Search(new SearchPostModel { 
                        Keyword = "" 
                    }));
        }
    }
}