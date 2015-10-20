using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace challenge_mvc_asp.Models
{
    public class NewsViewModel
    {
        public NewsViewModel()
        {
            News = new List<NewsDataModel>();
        }

        public ICollection<NewsDataModel> News { get; set; }
    }
}