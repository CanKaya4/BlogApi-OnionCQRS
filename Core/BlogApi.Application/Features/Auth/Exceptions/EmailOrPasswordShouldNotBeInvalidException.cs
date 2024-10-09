using BlogApi.Application.Bases;

namespace BlogApi.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidException : BaseException
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Kullanıcı adı şifre yanlıştır.") { }
    }
}
