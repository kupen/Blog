using MakeupBlog.Basecore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Domain.Models
{
    public class ApplicationUser : BaseModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
    }
}
