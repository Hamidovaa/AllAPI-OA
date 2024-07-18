using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Application.Features.Auth.Command.Login
{
    public class LoginCommandRequest : IRequest<LoginCommandResponse>
    {
        [DefaultValue("hemidoffa55@gmail.com")]
        public string Email { get; set; }
        [DefaultValue("Asdfgh123")]
        public string Password { get; set; }
    }
}
