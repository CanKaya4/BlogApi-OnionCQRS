using BlogApi.Domain.Common;
using BlogApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Domain.Entities
{
    public class Category : EntityBase, IEntityBase
    {
        public Category()
        {

        }
        public Category(int parentId, string categoryname)
        {
            ParentId = parentId;
            CategoryName = categoryname;
        }
        public required int ParentId { get; set; }
        public required string CategoryName { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
