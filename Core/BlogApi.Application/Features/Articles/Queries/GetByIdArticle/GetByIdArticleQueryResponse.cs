using BlogApi.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetByIdArticle
{
    public class GetByIdArticleQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Keyword { get; set; }
        public bool IsDeleted { get; set; }
        public TagDto Tag { get; set; }
        public List<string> CategoryNames { get; set; }
    }
}
