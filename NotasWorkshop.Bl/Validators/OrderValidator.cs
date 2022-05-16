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
    public class OrderValidator : BaseValidator<OrderDto>
    {
        public OrderValidator()
        {
            RuleFor(o => o.Total ).NotNull().NotEmpty().WithMessage("It can't be Empty");
            RuleFor(o => o.Date).LessThanOrEqualTo(DateTime.Now).WithMessage("The Date has to be Less Or Equals today");
        }
    }
}
