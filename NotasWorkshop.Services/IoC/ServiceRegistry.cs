using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotasWorkshop.Model.Entities;
using NotasWorkshop.Services.Services;
//using NotasWorkshop.Services.Services;

namespace NotasWorkshop.Services.IoC
{
    public static class ServiceRegistry
    {
        public static void AddServicesRegistry(this IServiceCollection services)
        {
            //services.AddScoped<INoteService, NoteService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IShoppingListService, ShoppingListService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService,OrderService>();
            services.AddScoped<IProductCategoryService,ProductCategoryService>();

        }
    }
}
