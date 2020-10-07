using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataLayer.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public IAsyncEnumerable<TEntity> AsAsyncEnumerable();

        public IQueryable<TEntity> AsQueryable();

        public TEntity Find(params object[] keyValues);

        public ValueTask<TEntity> FindAsync(params object[] keyValues);

        public ValueTask<TEntity> FindAsync(object[] keyValues, CancellationToken cancellationToken);

        public EntityEntry<TEntity> Add(TEntity entity);

        public ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity, CancellationToken cancellationToken = new CancellationToken());

        public EntityEntry<TEntity> Attach(TEntity entity);

        public EntityEntry<TEntity> Remove(TEntity entity);

        public EntityEntry<TEntity> Update(TEntity entity);

        public void AddRange(params TEntity[] entities);

        public Task AddRangeAsync(params TEntity[] entities);

        public void AttachRange(params TEntity[] entities);

        public void RemoveRange(params TEntity[] entities);

        public void UpdateRange(params TEntity[] entities);

        public void AddRange(IEnumerable<TEntity> entities);

        public Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = new CancellationToken());

        public void AttachRange(IEnumerable<TEntity> entities);

        public void RemoveRange(IEnumerable<TEntity> entities);

        public void UpdateRange(IEnumerable<TEntity> entities);
    }
}
