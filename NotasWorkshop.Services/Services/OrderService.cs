using AutoMapper;
using NotasWorkshop.Model.Contexts.NotasWorkshop;
using NotasWorkshop.Model.Entities;
using NotasWorkshop.Model.UnitOfWorks;
using NotasWorkshop.Services.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasWorkshop.Services.Services
{
    public interface IOrderService : IEntityCRUDService<Order,OrderDto>
    {

    }
    public class OrderService : EntityCRUDService<Order,OrderDto>, IOrderService
    {
        public OrderService(IMapper mapper, IUnitOfWork<INotasWorkshopDbContext> uow)
            : base(mapper, uow)
        {
        }
    }
}
