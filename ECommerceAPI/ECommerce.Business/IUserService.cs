using ECommerce.Entities;

namespace ECommerce.Business
{
    public interface IUserService
    {
        User Validate(string username, string password);
    }
}