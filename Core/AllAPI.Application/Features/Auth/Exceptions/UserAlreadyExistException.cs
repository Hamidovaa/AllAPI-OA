using AllAPI.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Application.Features.Auth.Exceptions
{
    public class UserAlreadyExistException :BaseExceptions
    {
        public UserAlreadyExistException() : base("User already exist") { }
    }
}
