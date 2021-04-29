using MakeupBlog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Datacore.Mapping
{
    public class ArticleImageMap : BaseMap<ArticleImage>
    {
        public ArticleImageMap()
        {
            ToTable("ArticleImages");

            HasRequired(x => x.Article)
                .WithMany(x => x.ArticleImages)
                .HasForeignKey(x => x.ArticleId)
                .WillCascadeOnDelete(false);
        }
    }
}
