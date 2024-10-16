using BlogApi.Application.Features.Articles.Command.CreateArticle;
using BlogApi.Application.Features.Articles.Command.DeleteArticle;
using BlogApi.Application.Features.Articles.Command.IncrementViewCountArticle;
using BlogApi.Application.Features.Articles.Command.UpdateArticle;
using BlogApi.Application.Features.Articles.Queries.GetAllArticles;
using BlogApi.Application.Features.Articles.Queries.GetByIdArticle;
using BlogApi.Application.Features.Articles.Queries.GetTotalArticleCount;
using BlogApi.Application.Features.Articles.Queries.GetTotalReadCountArticles;
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
        //   [Authorize]
        public async Task<IActionResult> GetAllArticles()
        {
            var response = await _mediator.Send(new GetAllArticlesQueryRequest());
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateArticle([FromBody] CreateArticleCommandRequest request)
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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdArticle(int id)
        {
            var incrementRequest = new IncrementViewCountArticleCommandRequest(id);
            await _mediator.Send(incrementRequest);

            var query = new GetByIdArticleQueryRequest(id);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetTotalReadCount()
        {
            var query = new GetTotalReadCountArticleQueryRequest();
            var totalReadCount = await _mediator.Send(query);
            return Ok(totalReadCount);

        }
        [HttpGet]
        public async Task<IActionResult> GetTotalArticleCount()
        {
            var query = new GetTotalArticleCountQueryRequest();
            var totalArticleCount = await _mediator.Send(query);
            return Ok(totalArticleCount);
        }
    }
}
