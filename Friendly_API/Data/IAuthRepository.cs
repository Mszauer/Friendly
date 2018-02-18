using System.Threading.Tasks;
using Friendly.Models;

namespace Friendly.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> LoginAsync(string username, string password);
        Task<bool> UserExists(string username);
    } 
}