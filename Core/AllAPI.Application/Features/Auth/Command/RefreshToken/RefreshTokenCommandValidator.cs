﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Application.Features.Auth.Command.RefreshToken
{
    public class RefreshTokenCommandValidator : AbstractValidator<RefreshTokenCommandRequest>
    {

        public RefreshTokenCommandValidator()
        {
            RuleFor(x => x.AccesToken).NotEmpty();
            RuleFor(x=> x.RefreshToken).NotEmpty();
        }
    }
}
