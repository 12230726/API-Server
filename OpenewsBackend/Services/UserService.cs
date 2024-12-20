using Microsoft.EntityFrameworkCore;
using OpenewsBackend.Data;
using OpenewsBackend.Models;

namespace OpenewsBackend.Services
{
    public class UserService : IUserService
    {
        private readonly OpenewsDbContext _context;

        public UserService(OpenewsDbContext context)
        {
            _context = context;
        }

        public async Task<bool> LoginAsync(LoginRequest request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email && u.Password == request.Password);
            return user != null;
        }

        public async Task<bool> SignupAsync(User user)
        {
            if (await _context.Users.AnyAsync(u => u.Email == user.Email))
                return false;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
