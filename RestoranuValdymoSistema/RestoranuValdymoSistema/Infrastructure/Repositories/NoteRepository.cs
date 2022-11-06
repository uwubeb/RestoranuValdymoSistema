using Microsoft.EntityFrameworkCore;
using RestoranuValdymoSistema.Data;
using RestoranuValdymoSistema.Data.Constants;
using RestoranuValdymoSistema.Data.Exceptions;
using RestoranuValdymoSistema.Data.Models;

namespace RestoranuValdymoSistema.Infrastructure.Repositories;

public class NoteRepository : BaseRepository<Note>, INoteRepository
{
    public NoteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }


    public async Task<List<Note>> Get(Guid restaurantId, Guid orderId)
    {
        return await DbContext.Notes
            .Include(x => x.Order)
            .Where(o => o.Order.RestaurantId == restaurantId && o.OrderId == orderId)
            .ToListAsync();

    }

    public async Task<Note?> Get(Guid restaurantId, Guid orderId, Guid noteId)
    {
        return await DbContext.Notes
            .Include(x => x.Order)
            .Where(o => o.Order.RestaurantId == restaurantId && o.OrderId == orderId)
            .FirstOrDefaultAsync(x => x.Id == noteId);
        
    }

    public async Task Create(Guid restaurantId, Guid orderId, Note note)
    {

        if (!DbContext.Orders.Any(r => r.RestaurantId == restaurantId && r.Id == orderId))
        {
            throw new NotFoundException(ExceptionConstants.NotFound<Order>());
        }
        note.OrderId = orderId;
        await DbContext.Notes.AddAsync(note);
        await DbContext.SaveChangesAsync();
    }

    public async Task Update(Guid restaurantId, Guid orderId, Note note)
    {
        var noteToUpdate =
            await DbContext.Notes
                .Include(x => x.Order)
                .Where(o => o.Order.RestaurantId == restaurantId && o.OrderId == orderId)
                .FirstOrDefaultAsync(x => x.Id == note.Id);

        noteToUpdate = note ?? throw new NotFoundException(ExceptionConstants.NotFound<Note>());
        DbContext.Notes.Update(noteToUpdate);
        await DbContext.SaveChangesAsync();
    }

    public async Task Delete(Guid restaurantId, Guid orderId, Guid noteId)
    {
        var note =
            await DbContext.Notes
                .Include(x => x.Order)
                .Where(o => o.Order.RestaurantId == restaurantId && o.OrderId == orderId)
                .FirstOrDefaultAsync(x => x.Id == noteId) ?? throw new NotFoundException(ExceptionConstants.NotFound<Note>());
        
        DbContext.Remove(note);
        await DbContext.SaveChangesAsync();
    }
}

public interface INoteRepository
{
    Task<List<Note>> Get(Guid restaurantId, Guid orderId);
    Task<Note?> Get(Guid restaurantId, Guid orderId, Guid noteId);
    Task Create(Guid restaurantId, Guid orderId, Note note);
    Task Update(Guid restaurantId, Guid orderId, Note note);
    Task Delete(Guid restaurantId, Guid orderId, Guid noteId);

}
