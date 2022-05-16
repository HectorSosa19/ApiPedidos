using AutoMapper;
using NotasWorkshop.Bl.Dtos;
using NotasWorkshop.Bl.Extensions;
using NotasWorkshop.Model.Entities;

namespace NotasWorkshop.Bl.Mappings
{
    public class NoteProfile : Profile
    {
        public NoteProfile()
        {
            //this._CreateMap_WithConventions_FromAssemblies<Note, NoteDto>();
            this._CreateMap_WithConventions_FromAssemblies<Product, ProductDto>();
            this._CreateMap_WithConventions_FromAssemblies<ShoppingList, ShoppingListDto>();
            this._CreateMap_WithConventions_FromAssemblies<ProductCategory, ProductCategoryDto>();
            this._CreateMap_WithConventions_FromAssemblies<Order, OrderDto>();
            this._CreateMap_WithConventions_FromAssemblies<Category, CategoryDto>();
            /// CreateMap<Note, NoteDto>().ReverseMap();
            /// CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
