using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Options;
using NotasWorkshop.Core.BaseModel.BaseEntity;
using NotasWorkshop.Core.Models;
using NotasWorkshop.Model.Entities;

namespace NotasWorkshop.Model.Contexts.NotasWorkshop
{
    public class NotasWorkshopDbContext : BaseDbContext, INotasWorkshopDbContext
    {
        public NotasWorkshopDbContext(DbContextOptions<NotasWorkshopDbContext> options,
            IOptions<AppSettings> appSettings)
            : base(options, appSettings)
        {
        }

        public DbSet<User> Users {get;set;}
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserDto> UserDtos { get; set; }
        public DbSet<T> GetDbSet<T>() where T : class, IBaseEntity => Set<T>();

        ChangeTracker INotasWorkshopDbContext.ChangeTracker()
        {
            return base.ChangeTracker;
        }
    }
}
