using BlogApi.Application.Features.Auth.Command.Login;
using BlogApi.Application.Features.Auth.Command.RefreshToken;
using BlogApi.Application.Features.Auth.Command.Register;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthContoller : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthContoller(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterCommandRequest request)
        {
            await _mediator.Send(request);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }
        [HttpPost]
        public async Task<IActionResult> RefreshToken(RefreshTokenCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
