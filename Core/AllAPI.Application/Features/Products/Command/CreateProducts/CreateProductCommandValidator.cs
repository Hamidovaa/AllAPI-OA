using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Application.Features.Products.Command.CreateProducts
{
    public class CreateProductCommandValidator :AbstractValidator<CreateProductCommandRequest>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithName("Header");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithName("Description");

            RuleFor(x => x.BrandId)
                .GreaterThan(0)
                .WithName("Brand");

            RuleFor(x => x.Price)
                .GreaterThan(0)
                .WithName("Price");

            RuleFor(x => x.Discount)
                .GreaterThanOrEqualTo(0)
                .WithName("Discount");

            RuleFor(x => x.CategoryIds)
                .NotEmpty()
                .Must(categories => categories.Any())
                .WithName("Categories");
        }
    }
}
