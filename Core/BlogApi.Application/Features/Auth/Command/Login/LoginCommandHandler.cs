using BlogApi.Application.Bases;
using BlogApi.Application.Features.Auth.Rules;
using BlogApi.Application.Interfaces.AutoMapper;
using BlogApi.Application.Interfaces.Tokens;
using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Auth.Command.Login
{
    public class LoginCommandHandler : BaseHandler, IRequestHandler<LoginCommandRequest, LoginCommandResponse>
    {
        private readonly UserManager<User> _userManager;
        private readonly AuthRules _authRules;
        private readonly ITokenService _tokenService;
        private readonly IConfiguration _configuration;
        public LoginCommandHandler(UserManager<User> userManager, AuthRules authRules, ITokenService tokenService, IConfiguration configuration, ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _userManager = userManager;
            _authRules = authRules;
            _tokenService = tokenService;
            _configuration = configuration;
        }
        public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
        {

            var user = await _userManager.FindByEmailAsync(request.Email);
            bool checkPassword = await _userManager.CheckPasswordAsync(user, request.Password);

            await _authRules.EmailOrPasswordShouldNotBeInvalid(user, checkPassword);

            IList<string> roles = await _userManager.GetRolesAsync(user);

            JwtSecurityToken token = await _tokenService.CreateToken(user, roles);

            string refreshToken = _tokenService.GenerateRefreshToken();

            _ = int.TryParse(_configuration["JWT:RefreshTokenValidityInDays"], out int refreshTokenValidityInDays);

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(refreshTokenValidityInDays);

            await _userManager.UpdateAsync(user);
            await _userManager.UpdateSecurityStampAsync(user);

            string _token = new JwtSecurityTokenHandler().WriteToken(token);

            await _userManager.SetAuthenticationTokenAsync(user, "Default", "AccessToken", _token);

            return new LoginCommandResponse()
            {
                Token = _token,
                RefreshToken = refreshToken,
                Expiration = token.ValidTo,
            };

        }
    }
}
