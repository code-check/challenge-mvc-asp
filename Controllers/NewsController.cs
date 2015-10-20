using challenge_mvc_asp.Interfaces;
using challenge_mvc_asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace challenge_mvc_asp.Controllers
{
    public class NewsController : NewsBaseController
    {
        //BEGIN_CHALLENGE
        public override ActionResult Index()
        {
            return View(new NewsViewModel { News = News.ToArray() });
        }

        public override ActionResult Search(SearchPostModel model)
        {
            return View(new SearchViewModel
            {
                News = News.Where(x => x.Author.Contains(model.Keyword) || x.Title.Contains(model.Keyword)).ToArray()
            });
        }

        public override ActionResult Feed(SearchPostModel model)
        {
            return Json(new SearchViewModel
            {
                News = News.Where(x => x.Author.Contains(model.Keyword) || x.Title.Contains(model.Keyword)).ToArray()
            });
        }
        //END_CHALLENGE
    }
}