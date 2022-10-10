using RestoranuValdymoSistema.Data.Models.Base;
using System.Linq.Expressions;

namespace RestoranuValdymoSistema.Infrastructure.Repositories;

public interface IRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity?> GetById(Guid id);
    Task<TProjection?> GetById<TProjection>(Guid id, Expression<Func<TEntity, TProjection>> projectionExpression);
    Task<List<TEntity>> GetWhere(Expression<Func<TEntity, bool>> filter);
    Task<List<TProjection>> GetWhere<TProjection>(
        Expression<Func<TEntity, bool>> filter,
        Expression<Func<TEntity, TProjection>> projectionExpression
    );
    Task<List<TEntity>> GetAll();

    Task Create(TEntity entity);
    Task Update(TEntity entity);
    Task Delete(TEntity entity);

    Task<List<TEntity>> GetMany(List<Guid> ids);
    Task<List<TProjection>> GetMany<TProjection>(List<Guid> ids, Expression<Func<TEntity, TProjection>> projectionExpression);
    Task CreateMany(List<TEntity> entities);
    Task UpdateMany(List<TEntity> entities);
    Task DeleteMany(List<TEntity> entities);

    Task<int> Count(Expression<Func<TEntity, bool>>? expression = null);
    Task<bool> Exists(Expression<Func<TEntity, bool>> expression);
}