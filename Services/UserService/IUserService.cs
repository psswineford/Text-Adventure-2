using Text_Adventure_2.Models;

namespace Text_Adventure_2.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<User> LoginUser(string email, string password);
        Task<User> AddUser(User user);
    }
}
