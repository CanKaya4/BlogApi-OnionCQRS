using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetArticleWithPagination
{
    public class GetArticleWithPaginationRequest : IRequest<GetArticleWithPaginationResponse>
    {
        //public GetArticleWithPaginationRequest(int pageNumber, int pageSize, string? searchKeyword, int? categoryId)
        //{
        //    PageNumber = pageNumber > 0 ? pageNumber : 1; // Sayfa numarası 0'dan küçükse 1 yap
        //    PageSize = pageSize > 0 ? pageSize : 10; // Sayfa boyutu 0'dan küçükse 10 yap
        //    SearchKeyword = searchKeyword;
        //    CategoryId = categoryId;
        //}
        public GetArticleWithPaginationRequest()
        {
            
        }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SearchKeyword { get; set; }
        public int? CategoryId { get; set; }
    }
}
