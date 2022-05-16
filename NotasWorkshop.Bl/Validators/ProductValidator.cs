using NotasWorkshop.Bl.Validators.Generic;
using NotasWorkshop.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
namespace NotasWorkshop.Bl.Validators
{
    public class ProductValidator : BaseValidator<ProductDto>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).Length(20).NotNull().NotEmpty().WithMessage("It can't be empty,More than 20 words Or Null");
            RuleFor(p => p.Category).Length(30).NotEmpty().WithMessage("It can't be Empty or Cannot be More than 30 words");
            RuleFor(p => p.Price).NotEmpty().NotNull().WithMessage("This value can't be null or be Empty");
            RuleFor(p => p.DateOfExpiry).NotEmpty().NotNull() ;
            RuleFor(p => p.Image).NotNull().WithMessage("You have to put a pic");
            RuleFor(p => p.Description).Length(100).WithMessage("It can't have More than 100 word ");
            RuleFor(p => p.Stock).NotNull().NotEmpty().WithMessage("It can't be empty or be Null");
        }
    }
}
