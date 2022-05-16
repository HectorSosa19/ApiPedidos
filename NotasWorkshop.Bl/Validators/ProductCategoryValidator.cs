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
    public class ProductCategoryValidator : BaseValidator<ProductCategoryDto>
    {
        public ProductCategoryValidator()
        {
            RuleFor(p => p.ProductCategoryId).NotEmpty().NotNull().WithMessage("It cant't be Null or be Empty");
        }
    }
}
