using AllAPI.Application.Bases;

namespace AllAPI.Application.Features.Auth.Exceptions
{
    public class RefreshTokenShouldNotBeExpiredException : BaseExceptions
    {
        public RefreshTokenShouldNotBeExpiredException() : base("Otum suresi bitdi.Yeniden giris yapin.") { }


    }
   
}
