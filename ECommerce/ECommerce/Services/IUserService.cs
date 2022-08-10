using ECommerce.Models;

namespace ECommerce.Services
{
    public interface IUserService
    {
        public User Validate(string username, string password);
    }
}
