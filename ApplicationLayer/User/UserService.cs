using System.Collections.Generic;
using DataLayer.Repositories;
using DomainLayer.User;

namespace ApplicationLayer.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<IUser> List(int limit, int offset)
        {
            return _repository.FindAll(limit, offset);
        }

        public int GetListCount()
        {
            return (int) _repository.Count();
        }
    }
}
