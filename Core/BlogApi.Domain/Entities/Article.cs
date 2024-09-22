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
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required int TagId { get; set; }
        public required int CategoryId { get; set; }
        public required Tag Tag { get; set; }
        public required ICollection<Category> Categories { get; set; }
        //public required string ImagePath { get; set; }
    }
}
