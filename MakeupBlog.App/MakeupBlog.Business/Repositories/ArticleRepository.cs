using MakeupBlog.Basecore.Data.EntityFramework.Abstract;
using MakeupBlog.Basecore.Data.EntityFramework.Concrete;
using MakeupBlog.Datacore.Context;
using MakeupBlog.Domain.Models;

namespace MakeupBlog.Business.Repositories
{
    public interface IArticleRepository : IRepository<Article> { }

    public class ArticleRepository : Repository<BlogDbContext, Article>, IArticleRepository
    {
        public ArticleRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
