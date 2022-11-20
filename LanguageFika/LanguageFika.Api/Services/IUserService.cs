using LanguageFika.Api.Models;

namespace LanguageFika.Api.Services;

public interface IUserService
{
    Task<User> GetUsersAsync();
    Task<User> GetUserAsync(Guid id);
    
    Task<User> CreateUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task DeleteUserAsync(Guid id);
}