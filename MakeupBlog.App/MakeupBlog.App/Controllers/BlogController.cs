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
    public class BlogController : Controller
    {
        // GET: Blog
        private readonly IArticleRepository arepo;
        private readonly ICategoryRepository crepo;
        public BlogController(IArticleRepository a_repo, ICategoryRepository c_repo)
        {
            arepo = a_repo;
            crepo = c_repo;
        }
        public ActionResult Index(int cId)
        {
            List<Article> articles = new List<Article>();
            articles = arepo.GetList(x => x.CategoryId == cId, "ArticleImages");
          
            return View(articles);
        }
        
        public ActionResult BlogSingle(int id)
        {
            var artic = arepo.Get(x => x.Id == id);
            return View(artic);
        }
    }
}