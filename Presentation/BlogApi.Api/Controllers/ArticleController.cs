using BlogApi.Application.Features.Articles.Command.CreateArticle;
using BlogApi.Application.Features.Articles.Command.DeleteArticle;
using BlogApi.Application.Features.Articles.Command.UpdateArticle;
using BlogApi.Application.Features.Articles.Queries.GetAllArticles;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ArticleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllArticles()
        {
            var response = await _mediator.Send(new GetAllArticlesQueryRequest());
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateArticle(CreateArticleCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateArticle(UpdateArticleCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteArticle(DeleteArticleCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();    
        }
    }
}
