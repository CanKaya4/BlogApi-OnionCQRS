using BlogApi.Application.Features.Tags.Commands.CreateTag;
using BlogApi.Application.Features.Tags.Commands.DeleteTag;
using BlogApi.Application.Features.Tags.Commands.UpdateTag;
using BlogApi.Application.Features.Tags.Queries.GetAllTags;
using BlogApi.Application.Features.Tags.Queries.GetByIdTags;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TagController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTags()
        {
            var response = await _mediator.Send(new GetAllTagsQueryRequest());
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTag(UpdateTagCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteTag(DeleteTagCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
        [HttpGet("{id}")]  
        public async Task<IActionResult> GetByIdTag(int id)
        {
            var query = new GetByIdTagsQueryRequest(id);
            var result =  await _mediator.Send(query);
            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
