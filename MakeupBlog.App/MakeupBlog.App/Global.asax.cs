using MakeupBlog.Business.Modules;
using Ninject;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MakeupBlog.App
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            base.OnApplicationStarted();
        }

        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new RepositoryModule());
        }
    }
}
