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
        public Article()
        {
            
        }
        public Article(string title, string content, int tagId, string keyword, string description)
        {
            Title = title;
            Content = content;
            TagId = tagId;
            Keyword = keyword;
            Description = description;
        }
        public  string Title { get; set; } 
        public  string Content { get; set; } 
        public  int TagId { get; set; }
        public  int ReadCount { get; set; }
        public string? Keyword { get; set; } 
        public string? Description { get; set; } 
        public  Tag Tag { get; set; }
        public  ICollection<ArticleCategory> ArticleCategories { get; set; }
        //public required string ImagePath { get; set; }
    }
}
