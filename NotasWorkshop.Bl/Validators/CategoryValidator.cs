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
    public class CategoryValidator : BaseValidator<CategoryDto>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).Length(30).WithMessage("It can't pass of 30 words");
        }
    }
}
