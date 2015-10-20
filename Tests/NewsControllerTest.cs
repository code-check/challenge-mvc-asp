using challenge_mvc_asp.Controllers;
using challenge_mvc_asp.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcContrib.TestHelper;
using challenge_mvc_asp.Models;
using System.Web.Mvc;

namespace challenge_mvc_asp.Tests
{
    [TestFixture]
    public class NewsControllerTest : NewsController
    {
        [Test]
        public void InheritanceTest()
        {
            Assert.IsInstanceOf<NewsBaseController>(this);
        }

        [Test]
        public void IndexTest()
        {
            var model = Index().AssertViewRendered().Model;
            Assert.IsInstanceOf<NewsViewModel>(model);
            Assert.AreEqual(5, (model as NewsViewModel).News.Count);
        }

        [Test]
        public void SearchTest()
        {
            var model = Search(new SearchPostModel { Keyword = "Givery" }).AssertViewRendered().Model;
            Assert.IsInstanceOf<NewsViewModel>(model);
            Assert.AreEqual(4, (model as NewsViewModel).News.Count);

            model = Search(new SearchPostModel { Keyword = "0" }).AssertViewRendered().Model;
            Assert.IsInstanceOf<NewsViewModel>(model);
            Assert.AreEqual(1, (model as NewsViewModel).News.Count);
        }

        [Test]
        public void FeedTest()
        {
            var result = Feed(new SearchPostModel { Keyword = "Givery" });
            Assert.IsInstanceOf<JsonResult>(result);

            var data = (result as JsonResult).Data;
            Assert.IsInstanceOf<NewsViewModel>(data);
            Assert.AreEqual(4, (data as NewsViewModel).News.Count);
        }
    }
}