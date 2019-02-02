using System.Collections.Generic;
using WFM.Entity;


namespace WFM.Services.Interfaces
{
    public interface IUserService
    {
        List<User> getAllUsers();
    }
}
