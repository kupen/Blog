using MakeupBlog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Datacore.Mapping
{
    public class ArticleMap : BaseMap<Article>
    {
        public ArticleMap()
        {
            ToTable("Artlicles");

            Property(x => x.Title).IsRequired();
            Property(x => x.Content).IsRequired();

            HasRequired(x => x.Category)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.CategoryId)
                .WillCascadeOnDelete(false);

            HasMany(x => x.ArticleImages)
                .WithRequired(x => x.Article)
                .HasForeignKey(x => x.ArticleId)
                .WillCascadeOnDelete(false);
        }
    }
}
