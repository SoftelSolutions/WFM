using System.Collections.Generic;
using System.Linq;
using WFM.Entity;
using WFM.Services.Interfaces;

namespace WFM.Services.Services
{
   public class LoginService : ILoginService
    {
        private WFMContext _context;

        public LoginService(WFMContext context)
        {
            _context = context;
        }

        public bool Login(string userName, string password)
        {
            var result = _context.Users.Where(x => x.UserName == userName && x.Password == password).SingleOrDefault();

            if (result != null)
                return true;
            else
                return false;
        }

        
    }
}
