using MakeupBlog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Datacore.Mapping
{
    public class CategoryMap : BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("Categories");

            HasRequired(x => x.MasterCategory)
                .WithMany(x => x.Categories)
                .HasForeignKey(x => x.MasterCategoryId)
                .WillCascadeOnDelete(false);

            HasMany(x => x.Articles)
                .WithRequired(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .WillCascadeOnDelete(false);
        }
    }
}
