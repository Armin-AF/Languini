using LanguageFika.Api.Models;
using LanguageFika.Api.Models.ViewModels;

namespace LanguageFika.Api;

public static class Extensions
{
    public static UserViewModel ToViewModel(this User? user)
    {
        if (user == null)
            return null!;
        
        return new UserViewModel
        {
            FirstName = user.FirstName!,
            LastName = user.LastName!,
            PhoneNumber = user.PhoneNumber!,
            BirthDate = user.BirthDate,
            Email = user.Email!,
            Description = user.Description,
            LearningLanguage = user.LanguageToLearn,
            TeachingLanguage = user.LanguageToTeach,
            StreetAddress = user.StreetAddress,
            City = user.City,
            Country = user.Country,
            PostalCode = user.PostalCode
        };
    }
    
    public static MeetingViewModel ToViewModel(this Meeting? meeting)
    {
        if (meeting == null)
            return null!;
        
        return new MeetingViewModel
        {
            Date = meeting.Date,
            Description = meeting.Description,
            Language = meeting.Language,
            Location = meeting.Location,
        };
    }
}