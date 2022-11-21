using LanguageFika.Api.Context;
using LanguageFika.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace LanguageFika.Api.Services;

public class MeetingService: IMeetingService
{
    
    readonly AppDbContext _dbContext;
    
    public MeetingService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<Meeting> GetMeetingsAsync(){
        return _dbContext.Meetings!.FirstOrDefaultAsync()!;
    }

    public Task<Meeting> PostMeetingAsync(Meeting meeting){
        _dbContext.Meetings!.Add(meeting);
        _dbContext.SaveChanges();
        return Task.FromResult(meeting);
    }
}