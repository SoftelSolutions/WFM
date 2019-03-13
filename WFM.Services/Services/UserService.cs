using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public Task<List<User>> GetAllUsers()
        {
            return _context.Users.ToListAsync();
        }

        public Task<List<User>> GetUserById(int userId)
        {
            return _context.Users.Where(u => u.Id == userId).ToListAsync();
        }

        public async Task<bool> CreateUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return await System.Threading.Tasks.Task.FromResult(true);
        }

        public async Task<List<User>> UpdateUser(int userId, User user)
        {
            if (userId != user.Id)
            {
                return null;
            }

            User userResult = _context.Users.Where(u => u.Id == userId).SingleOrDefault();

            if (userResult != null)
            {
                userResult.Password = user.Password;
                userResult.RoleId = user.RoleId;
                await _context.SaveChangesAsync();
            }
            return await _context.Users.Where(x => x.Id == userId).ToListAsync();
        }


        public Task<bool> DeleteUser(int userId)
        {
            var result = _context.Users.Where(u => u.Id == userId).FirstOrDefault();

            if (result != null)
            {
                result.IsDeleted = true;
                result.ActiveStatus = false;

                _context.Users.Update(result);
                _context.SaveChangesAsync();

                return System.Threading.Tasks.Task.FromResult(true);
            }
            else
            {
                return System.Threading.Tasks.Task.FromResult(false);
            }
        }
    }
}
