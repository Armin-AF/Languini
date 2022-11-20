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
        return _dbContext.Users!.FirstOrDefaultAsync()!;
    }

    public Task<User> GetUserAsync(Guid id){
        return _dbContext.Users!.FirstOrDefaultAsync(x => x.UserId == id)!;
    }

    public Task<User> CreateUserAsync(User user){
        _dbContext.Users!.Add(user);
        _dbContext.SaveChanges();
        return Task.FromResult(user);
    }

    public Task<User> UpdateUserAsync(User user){
        _dbContext.Users!.Update(user);
        _dbContext.SaveChanges();
        return Task.FromResult(user);
    }

    public Task DeleteUserAsync(Guid id){
        var user = _dbContext.Users!.FirstOrDefault(x => x.UserId == id);
        _dbContext.Users!.Remove(user!);
        _dbContext.SaveChanges();
        return Task.CompletedTask;
    }
}