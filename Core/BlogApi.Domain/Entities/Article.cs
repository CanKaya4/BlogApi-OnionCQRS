using BlogApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Domain.Entities
{
    public class Article : EntityBase
    {
        public  string Title { get; set; }
        public  string Content { get; set; }
        public  int TagId { get; set; }
        public  int CategoryId { get; set; }
        public  Tag Tag { get; set; }
        public  ICollection<Category> Categories { get; set; }
        //public required string ImagePath { get; set; }
    }
}
