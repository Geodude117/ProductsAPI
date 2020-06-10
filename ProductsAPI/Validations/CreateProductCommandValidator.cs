using FluentValidation;
using ProductsAPI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Validations
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty();
            RuleFor(x => x.Quantity).NotEmpty();
            RuleFor(x => x.Price).NotEmpty();

        }
    }
}
