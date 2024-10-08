﻿using BlogApi.Application.Bases;
using BlogApi.Application.Features.Auth.Exceptions;
using BlogApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Auth.Rules
{
    public class AuthRules : BaseRules
    {
        public Task UserShouldNotBeExists(User? user)
        {
            if(user is not null)
            {
                throw new UserAlreadyExitsException();
            }
            return Task.CompletedTask;
        }
        public Task EmailOrPasswordShouldNotBeInvalid(User? user, bool checkPassword)
        {
            if(user is null || !checkPassword)
            {
                throw new EmailOrPasswordShouldNotBeInvalidException();
            }
            return Task.CompletedTask;
        }
    }
}
