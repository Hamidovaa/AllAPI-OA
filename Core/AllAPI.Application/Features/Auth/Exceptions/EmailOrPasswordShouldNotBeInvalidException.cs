using AllAPI.Application.Bases;

namespace AllAPI.Application.Features.Auth.Exceptions
{
    public class EmailOrPasswordShouldNotBeInvalidException : BaseExceptions
    {
        public EmailOrPasswordShouldNotBeInvalidException() : base("Username or password wrong") { }
    }
}
