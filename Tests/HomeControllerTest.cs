using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcContrib.TestHelper;
using System.IO;
using challenge_mvc_asp.Interfaces;
using challenge_mvc_asp.Models;

namespace challenge_mvc_asp.Controllers
{
    [TestFixture]
    public class HomeControllerTest : HomeController
    {
        [Test]
        public void InheritanceTest()
        {
            Assert.IsInstanceOf<Controller>(this, "HomeController should inherrit Controller");
            Assert.IsInstanceOf<IHomeController>(this, "Please do not remove the IHomeController interface");
        }

        [Test]
        public void IndexTest()
        {
            Index().AssertViewRendered().ForView("HelloWorld");
        }

        [Test]
        public void DealTest()
        {
            Deal().AssertViewRendered().ForView("");
        }

        [Test]
        public void PageTest()
        {
            Page(-1).AssertActionRedirect().ToAction("Index");
            Page(0).AssertActionRedirect().ToAction("Index");
            Page(1).AssertViewRendered();

            object model = Page(10).AssertViewRendered().Model;
            Assert.IsInstanceOf<PageViewModel>(model);
            Assert.AreEqual(10, (model as PageViewModel).Id);
        }
    }
}