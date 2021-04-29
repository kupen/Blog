using MakeupBlog.Basecore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Domain.Models
{
    public class Category:BaseModel
    {
        public string Name { get; set; }
        //public string Description { get; set; }
        public int MasterCategoryId { get; set; } //ForeignKey
        public MasterCategory MasterCategory { get; set; }
        public List<Article> Articles { get; set; }
    }
}
