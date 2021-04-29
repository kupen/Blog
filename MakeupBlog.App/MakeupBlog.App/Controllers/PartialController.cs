using MakeupBlog.Business.Repositories;
using MakeupBlog.Datacore.Context;
using MakeupBlog.Datacore.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeupBlog.App.Controllers
{
    public class PartialController : Controller
    {

        // GET: Partial
        private readonly ICategoryRepository crepo;
        
        public PartialController(ICategoryRepository c_repo)
        {
            crepo = c_repo;
      
        }
        public PartialViewResult RenderHeader()
        {
            var mcs = crepo.GetList();
            return PartialView("~/Views/Shared/header.cshtml",mcs);
        }

        // canım benim neden hepsinde farklı versiyon yüklü :D bilmiyorum ne ara oldu o hepsine aynısı yüklemiştim ama sonrasında bir şeyler daha yaptım o ara olmuş olabilir... dur bakalım ninject mvc5 de yüklenmemiş :/:(:(:(  düzeldi sanırım sorun ne biliyor musun bir şey renderheader ı tekrar tekrar tetikliyor o yüzden taşma hatası veriyor  muhtemelen partial viewların birini normal view olarak oluşturdun bak normalde getiriyor masterları sonra tekrar çalışıyor continue diyince tekrar buraya takılıyor dikkat et evet fark ettim

        //public ActionResult Header()
        //{
        //    var model = ctx.Categories.ToList();
        //    return View(model);
        //}
        public PartialViewResult RenderFooter()
        {
            return PartialView("~/Views/Shared/footer.cshtml");
        }

        public PartialViewResult RenderSlider()
        {
            return PartialView("~/Views/Shared/Sections/slider.cshtml");
        }

        //public PartialViewResult RenderMainPart()
        //{
            
        //    return PartialView("~/Views/Shared/Sections/mainpart.cshtml");
        //}
    }

}