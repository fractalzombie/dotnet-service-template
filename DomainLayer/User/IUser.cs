using System;

namespace DomainLayer.User
{
    public interface IUser
    {
        public Guid Id { get; }
        public string Name { get; }
        public string CompanyName { get; }
        public string Position { get; }
        public string Image { get; }
        public string Email { get; }
        public string Password { get; }
        public bool Active { get; }
    }
}
