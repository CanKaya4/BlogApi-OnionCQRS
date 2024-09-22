using BlogApi.Application.Features.Articles.Queries.GetAllArticles;
using MediatR;
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
        public async Task<IActionResult> GetAllArticles()
        {
            var response = await _mediator.Send(new GetAllArticlesQueryRequest());
            return Ok(response);
        }
    }
}
