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
        public string Title { get; set; }
        public string Content { get; set; }
      

        public TagDto Tag { get; set; } 
    }
}
