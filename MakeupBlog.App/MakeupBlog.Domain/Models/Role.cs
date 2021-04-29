using MakeupBlog.Basecore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Domain.Models
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
    }
}
