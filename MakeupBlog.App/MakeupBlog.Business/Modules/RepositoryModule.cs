using MakeupBlog.Business.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Business.Modules
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IArticleRepository>().To<ArticleRepository>().InSingletonScope();
            Bind<IUserRepository>().To<UserRepository>().InSingletonScope();
            Bind<IImageRepository>().To<ArticleImageRepository>().InSingletonScope();
            Bind<ICategoryRepository>().To<CategoryRepository>().InSingletonScope();
            Bind<IMasterCategoryRepository>().To<MasterCategoryRepository>().InSingletonScope();
            Bind<IRoleRepository>().To<RoleRepository>().InSingletonScope();

        }
    }
}
