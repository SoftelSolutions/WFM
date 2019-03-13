using System.Collections.Generic;
using System.Threading.Tasks;
using WFM.Entity;


namespace WFM.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        
        Task<List<User>> GetUserById(int userId);

        Task<bool> CreateUser(User user);

        Task<List<User>> UpdateUser(int userId, User user);

        Task<bool> DeleteUser(int userId);
        
        


    }
}
