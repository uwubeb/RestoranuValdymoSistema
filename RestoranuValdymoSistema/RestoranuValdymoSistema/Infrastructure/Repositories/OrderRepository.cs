using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using RestoranuValdymoSistema.Data;
using RestoranuValdymoSistema.Data.Constants;
using RestoranuValdymoSistema.Data.Exceptions;
using RestoranuValdymoSistema.Data.Models;

namespace RestoranuValdymoSistema.Infrastructure.Repositories;

public class OrderRepository : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Order>> Get(Guid restaurantId)
    {
         return await DbContext.Orders.Where(o => o.RestaurantId == restaurantId).ToListAsync();
         
    }

    public async Task<Order?> Get(Guid restaurantId, Guid orderId)
    {
        return await DbContext.Orders.Where(o => o.RestaurantId == restaurantId && o.Id == orderId)
            .FirstOrDefaultAsync();
        
    }

    public async Task Create(Guid restaurantId, Order order)
    {
        if (!DbContext.Restaurants.Any(r => r.Id == restaurantId))
        {
            throw new NotFoundException(ExceptionConstants.NotFound<Restaurant>(restaurantId));
        }
        order.RestaurantId = restaurantId;
        await DbContext.Orders.AddAsync(order);
        await DbContext.SaveChangesAsync();
    }

    public async Task Update(Guid restaurantId, Order order)
    {
        var orderToUpdate = await DbContext.Orders.FirstOrDefaultAsync(o => o.Id == order.Id && o.RestaurantId == restaurantId);
        if (orderToUpdate is null) throw new NotFoundException(ExceptionConstants.NotFound<Order>());

        orderToUpdate = order;
        DbContext.Orders.Update(orderToUpdate);
        await DbContext.SaveChangesAsync();
    }
    

    public async Task Delete(Guid restaurantId, Guid orderId)
    {
        var order = await DbContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId && o.RestaurantId == restaurantId);
        if (order is null) throw new NotFoundException(ExceptionConstants.NotFound<Order>());
        DbContext.Orders.Remove(order);
        await DbContext.SaveChangesAsync();
    }

 
}