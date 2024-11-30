using BlogApi.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetArticleWithPagination
{
    public class GetArticleWithPaginationResponse
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public int TotalCount { get; set; } // Toplam makale sayısı

        // Makale bilgileri
        public List<ArticleDetail> Articles { get; set; } = new();

        public class ArticleDetail
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Keyword { get; set; }
            public string Slug { get; set; }
            public string Description { get; set; }
            public DateTime CreatedDate { get; set; }
            public bool IsDeleted { get; set; }
            public TagDto Tag { get; set; }
            public List<string> CategoryNames { get; set; } = new();
        }
    }
}
