using MakeupBlog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Datacore.Mapping
{
    public  class UserMap : BaseMap<ApplicationUser>
    {
        public UserMap()
        {
            ToTable("Users");
            //HasIndex(x => x.Email).IsUnique();
            
            

            HasRequired(x => x.Role)
                .WithMany(x => x.ApplicationUsers)
                .HasForeignKey(x => x.RoleId)
                .WillCascadeOnDelete(false);
            
        }
    }
}
