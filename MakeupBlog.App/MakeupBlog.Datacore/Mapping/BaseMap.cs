using MakeupBlog.Basecore.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Datacore.Mapping
{
    public class BaseMap<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseModel
    {
        public BaseMap()
        {
            Property(x => x.Created).HasColumnType("datetime2");
            Property(x => x.Updated).HasColumnType("datetime2");
            HasKey(x => x.Id);

        }
    }
}
