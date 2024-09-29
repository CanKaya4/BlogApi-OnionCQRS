using BlogApi.Application.DTOs;
using BlogApi.Application.Interfaces.AutoMapper;
using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Articles.Queries.GetAllArticles
{
    public class GetAllArticlesQueryHandler : IRequestHandler<GetAllArticlesQueryRequest, IList<GetAllArticlesQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICustomMapper _customMapper;
        public GetAllArticlesQueryHandler(IUnitOfWork unitOfWork, ICustomMapper customMapper)
        {
            _unitOfWork = unitOfWork;
            _customMapper = customMapper;
        }
        public async Task<IList<GetAllArticlesQueryResponse>> Handle(GetAllArticlesQueryRequest request, CancellationToken cancellationToken)
        {
            var articles = await _unitOfWork.GetReadRepository<Article>().GetAllAsync(include: x => x.Include(b => b.Tag));
            var tag = _customMapper.Map<TagDto, Tag>(new Tag());
            //List<GetAllArticlesQueryResponse> response = new();
            //foreach (var item in articles)
            //{
            //    response.Add(new GetAllArticlesQueryResponse()
            //    {
            //        Title = item.Title,

            //        Content = item.Content
            //    });
            //}
            var map = _customMapper.Map<GetAllArticlesQueryResponse, Article>(articles);

            // return map;
            throw new Exception("Hata mesajı");
        }
    }
}
