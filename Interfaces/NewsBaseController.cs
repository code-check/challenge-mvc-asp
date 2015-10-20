using challenge_mvc_asp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace challenge_mvc_asp.Interfaces
{
    public abstract class NewsBaseController : Controller
    {
        protected IEnumerable<NewsDataModel> News
        {
            get
            {
                yield return new NewsDataModel { Title = "Test Article 0", Author = "None" };
                yield return new NewsDataModel { Title = "Test Article 1", Author = "Givery Inc." };
                yield return new NewsDataModel { Title = "Test Article 2", Author = "Givery Inc." };
                yield return new NewsDataModel { Title = "Test Article 3", Author = "Givery Inc." };
                yield return new NewsDataModel { Title = "Test Article 4", Author = "Givery Inc." };
            }
        }

        public virtual ActionResult Index()
        {
            throw new NotImplementedException();
        }

        public virtual ActionResult Search(SearchPostModel model)
        {
            throw new NotImplementedException();
        }

        public virtual ActionResult Feed(SearchPostModel model)
        {
            throw new NotImplementedException();
        }
    }
}