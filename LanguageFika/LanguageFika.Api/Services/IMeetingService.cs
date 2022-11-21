using LanguageFika.Api.Models;

namespace LanguageFika.Api.Services;

public interface IMeetingService
{
    Task<Meeting> GetMeetingsAsync();
    
    Task<Meeting> PostMeetingAsync(Meeting meeting);
}