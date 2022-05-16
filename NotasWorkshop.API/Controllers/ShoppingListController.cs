using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotasWorkshop.Api.Controllers;
using NotasWorkshop.Model.Entities;
using NotasWorkshop.Services.Services;

namespace NotasWorkshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingListController : BaseController<ShoppingList,ShoppingListDto>
    {
        public ShoppingListController(IShoppingListService ShoppingListService,
            IValidatorFactory validationFactory,
            IMapper mapper) : base(ShoppingListService, validationFactory, mapper)
        {
        }
    }
}
