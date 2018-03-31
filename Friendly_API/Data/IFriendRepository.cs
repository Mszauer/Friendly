using System.Collections.Generic;
using System.Threading.Tasks;
using Friendly.Models;

namespace Friendly.Data
{
    public interface IFriendRepository
    {
        void Add<T> (T entity) where T : class; 
        void Delete<T> (T entity) where T : class;

        Task<bool> SavelAll();
        Task<IEnumerable<User>> GetUsers(); 
        Task<User> GetUser(int id);
    }
}