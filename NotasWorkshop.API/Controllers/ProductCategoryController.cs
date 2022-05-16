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
    public class ProductCategoryController : BaseController<ProductCategory,ProductCategoryDto>
    {
        public ProductCategoryController(IProductCategoryService ProductCategoryService,
            IValidatorFactory validationFactory,
            IMapper mapper) : base(ProductCategoryService, validationFactory, mapper)
        {

        }
    }
}
