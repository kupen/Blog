using MakeupBlog.Business.Repositories;
using MakeupBlog.Datacore.Context;
using MakeupBlog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeupBlog.App.Controllers
{
    public class HomeController : Controller
    {

        private readonly IArticleRepository arepo;
        public HomeController(IArticleRepository a_repo)
        {
            arepo = a_repo;
        }
        public ActionResult Index()
        {
            List<Article> articles = new List<Article>();
            articles = arepo.GetList(includeList: "ArticleImages"); 
           return View(articles);
        }
    }
}