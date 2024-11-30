using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetArticlesByTagWithPagination
{
    public class GetArticlesByTagWithPaginationRequest : IRequest<GetArticlesByTagWithPaginationResponse>
    {
        public int? TagId { get; set; } // Tag filtresi
        public int PageNumber { get; set; } = 1; // Varsayılan sayfa numarası
        public int PageSize { get; set; } = 10; // Varsayılan sayfa boyutu
    }
}
