using RestoranuValdymoSistema.Data.Models;

namespace RestoranuValdymoSistema.Infrastructure.Repositories;

public interface INoteRepository
{
    Task<List<Note>> Get(Guid restaurantId, Guid orderId);
    Task<Note> Get(Guid restaurantId, Guid orderId, Guid noteId);
    Task Create(Guid restaurantId, Guid orderId, Note note);
    Task Update(Guid restaurantId, Guid orderId, Note note);
    Task Delete(Guid restaurantId, Guid orderId, Guid noteId);

}