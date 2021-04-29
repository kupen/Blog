using MakeupBlog.Basecore.Data.EntityFramework.Abstract;
using MakeupBlog.Basecore.Data.EntityFramework.Concrete;
using MakeupBlog.Datacore.Context;
using MakeupBlog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Business.Repositories
{
    public interface IMasterCategoryRepository:IRepository<MasterCategory> { }
    public class MasterCategoryRepository : Repository<BlogDbContext, MasterCategory>,IMasterCategoryRepository
    {
        public MasterCategoryRepository(BlogDbContext context) : base(context)
        {

        }
    }
}
