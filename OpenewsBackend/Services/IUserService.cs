using OpenewsBackend.Models;

namespace OpenewsBackend.Services
{
    public interface IUserService
    {
        Task<bool> LoginAsync(LoginRequest request);
        Task<bool> SignupAsync(User user);
    }
}
