using AllAPI.Application.Bases;

namespace AllAPI.Application.Features.Auth.Exceptions
{
    public class EmailAddressShouldBeValidException : BaseExceptions
    {
        public EmailAddressShouldBeValidException() : base("Otum suresi bitdi.Yeniden giris yapin.") { }


    }

}
