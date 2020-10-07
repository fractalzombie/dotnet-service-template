using System.Collections.Generic;
using DomainLayer.User;

namespace ApplicationLayer.User
{
    public interface IUserService
    {
        public IEnumerable<IUser> List(int limit, int offset);
        public int GetListCount();
    }
}
