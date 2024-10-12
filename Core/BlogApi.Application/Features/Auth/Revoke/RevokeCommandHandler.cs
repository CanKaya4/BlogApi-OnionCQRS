using BlogApi.Application.Bases;
using BlogApi.Application.Features.Auth.Rules;
using BlogApi.Application.Interfaces.AutoMapper;
using BlogApi.Application.Interfaces.UnitOfWorks;
using BlogApi.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Auth.Revoke
{
    public class RevokeCommandHandler : BaseHandler, IRequestHandler<RevokeCommandRequest,Unit>
    {
        private readonly UserManager<User> _userManager;
        private readonly AuthRules _authRules;
        public RevokeCommandHandler(UserManager<User> userManager,AuthRules authRules ,ICustomMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            _userManager = userManager;
            _authRules = authRules;
        }

        public async Task<Unit> Handle(RevokeCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await _userManager.FindByEmailAsync(request.Email);
            await _authRules.EmailAddressShouldBeValid(user);

            user.RefreshToken = null;
            await _userManager.UpdateAsync(user);

            return Unit.Value;
        }
    }
}
