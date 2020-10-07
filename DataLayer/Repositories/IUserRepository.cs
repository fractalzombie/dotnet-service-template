using System.Collections.Generic;
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> FindAll(int limit, int offset);
        long Count();
    }
}
