using RestoranuValdymoSistema.Data.Models;

namespace RestoranuValdymoSistema.Infrastructure.Repositories;

public interface IOrderRepository
{
    Task<List<Order>> Get(Guid restaurantId);
    Task<Order?> Get(Guid restaurantId, Guid orderId);
    Task Create(Guid restaurantId, Order order);
    Task Update(Guid restaurantId, Order order);
    Task Delete(Guid restaurantId, Guid orderId);
    
}