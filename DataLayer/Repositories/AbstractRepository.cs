using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataLayer.Repositories
{
    public abstract class AbstractRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public DbContext Context { get; }
        public DbSet<TEntity> Source { get; }

        public AbstractRepository(DbContext context, DbSet<TEntity> source)
        {
            Context = context;
            Source = source;
        }

        public IAsyncEnumerable<TEntity> AsAsyncEnumerable() => Source.AsAsyncEnumerable();

        public IQueryable<TEntity> AsQueryable() => Source.AsQueryable();

        public TEntity Find(params object[] keyValues) => Source.Find(keyValues);

        public ValueTask<TEntity> FindAsync(params object[] keyValues) => Source.FindAsync(keyValues);

        public ValueTask<TEntity> FindAsync(object[] keyValues, CancellationToken cancellationToken) =>
            Source.FindAsync(keyValues, cancellationToken);

        public EntityEntry<TEntity> Add(TEntity entity) => Source.Add(entity);

        public ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity,
            CancellationToken cancellationToken = new CancellationToken()) =>
            Source.AddAsync(entity, cancellationToken);

        public EntityEntry<TEntity> Attach(TEntity entity) => Source.Attach(entity);

        public EntityEntry<TEntity> Remove(TEntity entity) => Source.Remove(entity);

        public EntityEntry<TEntity> Update(TEntity entity) => Source.Update(entity);

        public void AddRange(params TEntity[] entities) => Source.AddRange(entities);

        public Task AddRangeAsync(params TEntity[] entities) => Source.AddRangeAsync(entities);

        public void AttachRange(params TEntity[] entities) => Source.AttachRange(entities);

        public void RemoveRange(params TEntity[] entities) => Source.RemoveRange(entities);

        public void UpdateRange(params TEntity[] entities) => Source.UpdateRange(entities);

        public void AddRange(IEnumerable<TEntity> entities) => Source.AddRange(entities);

        public Task AddRangeAsync(IEnumerable<TEntity> entities,
            CancellationToken cancellationToken = new CancellationToken()) => Source.AddRangeAsync(entities);

        public void AttachRange(IEnumerable<TEntity> entities) => Source.AttachRange(entities);

        public void RemoveRange(IEnumerable<TEntity> entities) => Source.RemoveRange(entities);

        public void UpdateRange(IEnumerable<TEntity> entities) => Source.UpdateRange(entities);
    }
}
