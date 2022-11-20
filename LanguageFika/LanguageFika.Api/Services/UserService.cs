using LanguageFika.Api.Context;
using LanguageFika.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguageFika.Api.Services;

public class UserService: IUserService
{

    readonly AppDbContext _dbContext;
    
    public UserService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public Task<User> GetUsersAsync(){
        return _dbContext.Users.FirstOrDefaultAsync();
    }

    public Task<User> GetUserAsync(string username){
        throw new NotImplementedException();
    }

    public Task<User> GetUserAsync(Guid id){
        throw new NotImplementedException();
    }

    public Task<User> CreateUserAsync(User user){
        throw new NotImplementedException();
    }

    public Task<User> UpdateUserAsync(User user){
        throw new NotImplementedException();
    }

    public Task DeleteUserAsync(Guid id){
        throw new NotImplementedException();
    }
}