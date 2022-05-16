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
    public class ShoppingListValidator:BaseValidator<ShoppingListDto>
    {
        public ShoppingListValidator()
        {
            RuleFor(s => s.Count).NotEmpty().NotNull().WithMessage("It can't be empty or be null");
        }
    }
}
