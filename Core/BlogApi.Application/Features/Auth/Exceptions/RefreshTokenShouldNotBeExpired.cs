using BlogApi.Application.Bases;

namespace BlogApi.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpired : BaseException
    {
        public RefreshTokenShouldNotBeExpired() : base("Oturum açma süresi sona ermiştir. Lütfen tekrar giriş yapın") { }

    }

  
}
