using ECommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business
{
    public class FakeUserService : IUserService
    {
        private readonly List<User> _users;

        public FakeUserService()
        {
            _users = new List<User>
            {
                new User { Id = 1, Username = "User1", Password = "123456", Role = "Admin"},
                new User { Id = 2, Username = "User2", Password = "123456", Role = "Editor"},
                new User { Id = 3, Username = "User3", Password = "123456", Role = "Host"}
            };
        }

        public User Validate(string? username, string? password)
        {
            var user = _users.FirstOrDefault(u => u.Username.Equals(username) && u.Password.Equals(password));

            if (user is null)
                return null!;

            return user;
        }
    }
}
