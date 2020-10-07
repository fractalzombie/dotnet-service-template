using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Entities;
using DataLayer.Scopes;

namespace DataLayer.Repositories
{
    public class UserRepository : AbstractRepository<User>, IUserRepository
    {
        private const int CountIfException = 0;
        private const int LimitMax = 100;
        private const int LimitMin = 0;
        
        public UserRepository(AbstractUserScope scope) : base(scope, scope.Users)
        {
        }

        public IEnumerable<User> FindAll(int limit, int offset)
        {
            limit = Math.Clamp(limit, LimitMin, LimitMax);
            offset = Math.Abs(offset);
            
            return AsQueryable()
                .Skip(offset)
                .Take(limit)
                .ToList();
        }

        public long Count()
        {
            try
            {
                return AsQueryable().Select(u => u.Id).Count();
            }
            catch (ArgumentNullException)
            {
                return CountIfException;
            }
        }
    }
}
