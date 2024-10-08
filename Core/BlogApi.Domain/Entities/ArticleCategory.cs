﻿using BlogApi.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Domain.Entities
{
    public class ArticleCategory : IEntityBase
    {
        public int ArticleId { get; set; }
        public int CategoryId { get; set; }
        public Article Article { get; set; }
        public Category Category { get; set; }
    }
}
