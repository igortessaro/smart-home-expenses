using System.Linq.Expressions;

namespace SmartHome.Expenses.Domain.Repositories;

public interface IBaseRepository<TEntity> where TEntity : class
{
    //Task<IReadOnlyCollection<TSummary>> GetAllAsync<TSummary>() where TSummary : class;
    //IQueryable<TEntity> Query(int take = 100);
    //IQueryable<TProjection> Query<TProjection>(Expression<Func<TEntity, bool>> predicate) where TProjection : class;
    //IQueryable<TProjection> Query<TProjection>() where TProjection : class;
}