using RestoranuValdymoSistema.Data.Models.Base;
using RestoranuValdymoSistema.Data;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace RestoranuValdymoSistema.Infrastructure.Repositories;

public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly ApplicationDbContext DbContext;
    public BaseRepository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<TEntity?> GetById(Guid id)
    {
        return await DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<TProjection?> GetById<TProjection>(Guid id, Expression<Func<TEntity, TProjection>> projectionExpression)
    {
        return await DbContext.Set<TEntity>()
            .Where(entity => entity.Id == id)
            .Select(projectionExpression)
            .FirstOrDefaultAsync();
    }

    public async Task<List<TEntity>> GetWhere(Expression<Func<TEntity, bool>> filter)
    {
        return await DbContext.Set<TEntity>()
            .Where(filter)
            .ToListAsync();
    }

    public async Task<List<TProjection>> GetWhere<TProjection>(
        Expression<Func<TEntity, bool>> filter,
        Expression<Func<TEntity, TProjection>> projectionExpression
    )
    {
        return await DbContext.Set<TEntity>()
            .Where(filter)
            .Select(projectionExpression)
            .ToListAsync();
    }

    public async Task<List<TEntity>> GetAll()
    {
        return await DbContext.Set<TEntity>().ToListAsync();
    }

    public async Task Create(TEntity entity)
    {
        entity.CreationDate = DateTime.UtcNow;

        await DbContext.Set<TEntity>().AddAsync(entity);
        await DbContext.SaveChangesAsync();
    }

    public async Task Update(TEntity entity)
    {
        DbContext.Set<TEntity>().Update(entity);
        await DbContext.SaveChangesAsync();
    }

    public async Task Delete(TEntity entity)
    {
        DbContext.Set<TEntity>().Remove(entity);
        await DbContext.SaveChangesAsync();
    }

    public async Task<List<TEntity>> GetMany(List<Guid> ids)
    {
        return await DbContext.Set<TEntity>().Where(e => ids.Any(id => id == e.Id)).ToListAsync();
    }

    public async Task<List<TProjection>> GetMany<TProjection>(List<Guid> ids, Expression<Func<TEntity, TProjection>> projectionExpression)
    {
        return await DbContext.Set<TEntity>()
            .Where(e => ids.Any(id => id == e.Id))
            .Select(projectionExpression)
            .ToListAsync();
    }

    public async Task CreateMany(List<TEntity> entities)
    {
        await DbContext.Set<TEntity>().AddRangeAsync(entities);
        await DbContext.SaveChangesAsync();
    }

    public async Task UpdateMany(List<TEntity> entities)
    {
        DbContext.Set<TEntity>().UpdateRange(entities);
        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteMany(List<TEntity> entities)
    {
        DbContext.Set<TEntity>().RemoveRange(entities);
        await DbContext.SaveChangesAsync();

    }

    public async Task<int> Count(Expression<Func<TEntity, bool>>? expression = null)
    {
        var count = expression == null ? await DbContext.Set<TEntity>().CountAsync() : await DbContext.Set<TEntity>().CountAsync(expression);

        return count;
    }

    public async Task<bool> Exists(Expression<Func<TEntity, bool>> expression)
    {
        return await DbContext.Set<TEntity>().AnyAsync(expression);
    }
}