using Microsoft.EntityFrameworkCore;
using RestoranuValdymoSistema.Data;
using RestoranuValdymoSistema.Data.Constants;
using RestoranuValdymoSistema.Data.Contracts.Restaurant;
using RestoranuValdymoSistema.Data.Exceptions;
using RestoranuValdymoSistema.Data.Models;

namespace RestoranuValdymoSistema.Infrastructure.Repositories;

public class RestaurantRepository : BaseRepository<Restaurant>, IRestaurantRepository
{
    public RestaurantRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Restaurant>> Get()
    {
        return await DbContext.Restaurants.ToListAsync();
    }

    public async Task<Restaurant> Get(Guid restaurantId)
    {
        return await DbContext.Restaurants.FirstOrDefaultAsync(r => r.Id == restaurantId) ?? throw new NotFoundException(ExceptionConstants.NotFound<Restaurant>(restaurantId));
    }

    public new async Task Create(Restaurant restaurant)
    {
        await DbContext.Restaurants.AddAsync(restaurant);
        await DbContext.SaveChangesAsync();
    }

    public new async Task Update(Restaurant restaurantToUpdate)
    {
        var restaurant = await DbContext.Restaurants.FirstOrDefaultAsync(r => r.Id == restaurantToUpdate.Id) ?? throw new NotFoundException(ExceptionConstants.NotFound<Restaurant>());

        restaurant.PhoneNumber = restaurantToUpdate.PhoneNumber;
        restaurant.Address = restaurantToUpdate.Address;
        restaurant.Name = restaurantToUpdate.Name;
        restaurant.Email = restaurantToUpdate.Email;
        DbContext.Restaurants.Update(restaurant);
        await DbContext.SaveChangesAsync();
    }

    public async Task Delete(Guid restaurantId)
    {
        var restaurant = await DbContext.Restaurants.FirstOrDefaultAsync(r => r.Id == restaurantId) ?? throw new NotFoundException(ExceptionConstants.NotFound<Restaurant>());
        DbContext.Restaurants.Remove(restaurant);
        await DbContext.SaveChangesAsync();
    }
}

public interface IRestaurantRepository
{
    Task<List<Restaurant>> Get();
    Task<Restaurant> Get(Guid restaurantId);
    Task Create(Restaurant restaurant);
    Task Update(Restaurant restaurantToUpdate);
    Task Delete(Guid restaurantId);

}