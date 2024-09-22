using BlogApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Domain.Entities
{
    public class Tag : EntityBase
    {
        public Tag()
        {
            
        }
        public Tag(string name)
        {
          Name = name;
        }
        public string Name { get; set; }
    }
}
