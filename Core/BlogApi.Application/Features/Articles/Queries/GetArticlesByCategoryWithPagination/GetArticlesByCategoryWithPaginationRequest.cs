using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetArticlesByCategoryWithPagination
{
    public class GetArticlesByCategoryWithPaginationRequest : IRequest<GetArticlesByCategoryWithPaginationResponse>
    {
        public int CategoryId { get; set; }
        public int PageNumber { get; set; } = 1; // Varsayılan olarak 1. sayfa
        public int PageSize { get; set; } = 10; // Varsayılan olarak 10 makale
    }
}
