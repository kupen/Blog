using MakeupBlog.Basecore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeupBlog.Domain.Models
{
    public class ArticleImage:BaseModel
    {
        public string Path { get; set; }
        public Article Article { get; set; }
        public int ArticleId { get; set; }
    }
}
