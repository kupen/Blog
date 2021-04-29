using MakeupBlog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Datacore.Mapping
{
    public class RoleMap : BaseMap<Role>
    {
        public RoleMap()
        {
            ToTable("Roles");


        }
    }
}
