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
        public Category(int parentId, string categoryname,int priorty)
        {
            ParentId = parentId;
            CategoryName = categoryname;
            Priorty = priorty;
        }
        public  int ParentId { get; set; }
        public  int Priorty { get; set; }
        public  string CategoryName { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
