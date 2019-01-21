using System.Collections.Generic;
using System.Threading.Tasks;
using UdemytestApp.API.Helpers;
using UdemytestApp.API.Models;

namespace UdemytestApp.API.Data
{
    public interface IUserRepository
    {
        void Add<T>(T entity) where T:class; 
        void Delete<T>(T entity) where T:class;
        Task<bool> SaveAll();
        // Task<IEnumerable<User>> GetUsers();
        Task<PagedList<User>> GetUsers(UserParams userParams);
        Task<User> GetUser(int Id);
        Task<Photo> GetPhoto(int id);
        Task<Photo> GetMainPhotoForUser(int id);
        Task<Like> GetLike(int userId, int receipientId);
        Task<Message> GetMessage(int id);
        Task<PagedList<Message>> GetMessagesForUser();
        Task<IEnumerable<Message>> GetMessageThread(int userId, int receipientId);

    }
}