using LanguageFika.Api.Context;
using LanguageFika.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguageFika.Api.Services;

public class UserService : GenericRepository<User>, IUserService
{
    
    public UserService(AppDbContext context) : base(context)
    {
    }

    public override async Task<IEnumerable<User>> All(){
        try{
            return await dbSet.ToListAsync();
        }
        catch(Exception ex){
            return new List<User>();
        }
    }
    
    public override async Task<bool> Upsert(User entity){
        try
        {
            var existingUser = await dbSet.Where(x => x.UserId == entity.UserId)
                .FirstOrDefaultAsync();

            if (existingUser == null)
                return await Add(entity);

            existingUser.FirstName = entity.FirstName;
            existingUser.LastName = entity.LastName;
            existingUser.Email = entity.Email;

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    
    public override async Task<bool> Delete(Guid id){
        try{
            var user = await dbSet.Where(x => x.UserId == id)
                .FirstOrDefaultAsync();

            if (user == null)
                return false;

            dbSet.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }
        catch(Exception ex){
            return false;
        }
    }

}

