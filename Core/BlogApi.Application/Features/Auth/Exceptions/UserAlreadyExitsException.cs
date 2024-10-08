using BlogApi.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExitsException : BaseException
    {
        public UserAlreadyExitsException() : base("Böyle bir kullanıcı zaten var") { }
    }
}
