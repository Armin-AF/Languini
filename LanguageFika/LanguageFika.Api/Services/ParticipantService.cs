using LanguageFika.Api.Context;
using LanguageFika.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguageFika.Api.Services;

public class ParticipantService : GenericRepository<Participant>, IParticipantService
{
    public ParticipantService(AppDbContext context) : base(context){
    }

    public override async Task<IEnumerable<Participant>> All(){
        try{
            return await dbSet.ToListAsync();
        }
        catch (Exception ex){
            return new List<Participant>();
        }
    }

    public override async Task<bool> Upsert(Participant entity){
        try{
            var existingParticipant = await dbSet.Where(x => x.MeetingId == entity.MeetingId).FirstOrDefaultAsync();

            if (existingParticipant == null){
                await dbSet.AddAsync(entity);
            }
            else{
                existingParticipant.ParticipantId = entity.ParticipantId;
                existingParticipant.MeetingId = entity.MeetingId;
                existingParticipant.ParticipantEmail = entity.ParticipantEmail;
                dbSet.Update(existingParticipant);
                await _context.SaveChangesAsync();

                return true;
            }
        }
        catch (Exception ex){
            return false;
        }

        return false;

    }

    public override async Task<bool> Delete(Guid id){
        try{
            var existingParticipant = await dbSet.Where(x => x.ParticipantId == id).FirstOrDefaultAsync();
            if (existingParticipant != null){
                dbSet.Remove(existingParticipant);
                await _context.SaveChangesAsync();
                return true;
            }
        }
        catch (Exception ex){
            return false;
        }
        
        return false;
    }
}
    
