using BlogApi.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetAllArticles
{
    public class GetAllArticlesQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Keyword { get; set; } 
        public string Slug { get; set; }
        public bool IsDeleted { get; set; }
        public int ReadCount { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public TagDto Tag { get; set; }
        public List<string> CategoryNames { get; set; } 
    }
}
