using System.Collections.Generic;
using System.Linq;
using WFM.Entity;
using WFM.Services.Interfaces;

namespace WFM.Services.Services
{
    public class UserService : IUserService
    {
        private WFMContext _context;
 
        public UserService(WFMContext context)
        {
            _context = context;
        }

        public List<User> getAllUsers()
        {
            var result = _context.Users.ToList();
          
            return result;
        }
    }
}
