using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetArticleBySearch
{
    public class GetArticleBySearchRequest : IRequest<GetArticleBySearchResponse>
    {
        public string SearchTerm { get; set; }
        public GetArticleBySearchRequest(string searchTerm)
        {
            SearchTerm = searchTerm;
        }
    }
}
