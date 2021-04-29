using MakeupBlog.Basecore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Domain.Models
{

    public class Article : BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ArticleImage> ArticleImages { get; set; }
    }
}
