using System.Collections.ObjectModel;
using System.Linq.Expressions;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SmartHome.Expenses.Domain.Repositories;

namespace SmartHome.Expenses.Infrastructure.Repositories.Relational;

public abstract class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
{
    private readonly IMapper _mapper;
    private bool _disposed;
    private readonly DbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    protected BaseRepository(DbContext context, IMapper mapper)
    {
        this._context = context;
        this._dbSet = this._context.Set<TEntity>();
        this._mapper = mapper;
    }

    public async Task<IReadOnlyCollection<TSummary>> GetAllAsync<TSummary>() where TSummary : class
    {
        var result = await this.Query<TSummary>().ToListAsync();

        return new ReadOnlyCollection<TSummary>(result);
    }
    
    public async Task<int> InsertAsync(TEntity entity)
    {
        await this._dbSet.AddAsync(entity);
        return await this._context.SaveChangesAsync();
    }

    private IQueryable<TEntity> Query() => this._dbSet.AsNoTracking();

    protected IQueryable<TProjection> Query<TProjection>(Expression<Func<TEntity, bool>> predicate)
        where TProjection : class
    {
        return this.Query()
            .Where(predicate)
            .ProjectTo<TProjection>(this._mapper.ConfigurationProvider);
    }

    private IQueryable<TProjection> Query<TProjection>() where TProjection : class
    {
        return this.Query()
            .ProjectTo<TProjection>(this._mapper.ConfigurationProvider);
    }

    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (this._disposed)
        {
            return;
        }

        if (disposing)
        {
            this._context.Dispose();
        }

        this._disposed = true;
    }
}