using LanguageFika.Api.Context;
using LanguageFika.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguageFika.Api.Services;

public class MeetingService : GenericRepository<Meeting> , IMeetingService
{
    public MeetingService(AppDbContext context) : base(context)
    {
    }
    
    public override async Task<IEnumerable<Meeting>> All()
    {
        try{
            return await dbSet.ToListAsync();
        }
        catch(Exception ex){
            return new List<Meeting>();
        }
    }
    
    public override async Task<bool> Upsert(Meeting entity)
    {
        try
        {
            var existingUser = await dbSet.Where(x => x.Id == entity.Id)
                .FirstOrDefaultAsync();

            if (existingUser == null)
                return await Add(entity);

            existingUser.Language = entity.Language;
            existingUser.Date = entity.Date;
            existingUser.Description = entity.Description;
            existingUser.CreatorEmail= entity.CreatorEmail;

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
    
    public override async Task<bool> Delete(Guid id)
    {
        try
        {
            var existingUser = await dbSet.Where(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (existingUser == null)
                return false;

            dbSet.Remove(existingUser);
            await _context.SaveChangesAsync();

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}
