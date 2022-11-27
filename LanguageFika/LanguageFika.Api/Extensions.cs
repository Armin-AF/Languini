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
    
    public static User ToModel(this UserViewModel? user)
    {
        if (user == null)
            return null!;
        
        return new User
        {
            FirstName = user.FirstName!,
            LastName = user.LastName!,
            PhoneNumber = user.PhoneNumber!,
            BirthDate = user.BirthDate,
            Email = user.Email!,
            Description = user.Description,
            LanguageToLearn = user.LearningLanguage,
            LanguageToTeach = user.TeachingLanguage,
            StreetAddress = user.StreetAddress,
            City = user.City,
            Country = user.Country,
            PostalCode = user.PostalCode
        };
    }
    
    public static void UpdateModel(this UserViewModel? user, User? model)
    {
        if (user == null || model == null) return;

        model.FirstName = user.FirstName!;
        model.LastName = user.LastName!;
        model.PhoneNumber = user.PhoneNumber!;
        model.BirthDate = user.BirthDate;
        model.Email = user.Email!;
        model.Description = user.Description;
        model.LanguageToLearn = user.LearningLanguage;
        model.LanguageToTeach = user.TeachingLanguage;
        model.StreetAddress = user.StreetAddress;
        model.City = user.City;
        model.Country = user.Country;
        model.PostalCode = user.PostalCode;
    }

    public static MeetingViewModel ToViewModel(this Meeting? meeting)
    {
        if (meeting == null)
            return null!;
        
        return new MeetingViewModel
        {
            MeetingId = meeting.Id,
            Date = meeting.Date,
            Description = meeting.Description,
            Language = meeting.Language,
            Location = meeting.Location,
        };
    }
    
    public static Meeting ToModel(this MeetingViewModel? meeting)
    {
        if (meeting == null)
            return null!;
        
        return new Meeting
        {
            Id = meeting.MeetingId,
            Date = meeting.Date,
            Description = meeting.Description,
            Language = meeting.Language,
            Location = meeting.Location,
            Participants = new List<Participant>(),
        };
    }
    
    public static void UpdateModel(this MeetingViewModel? meeting, Meeting? model)
    {
        if (meeting == null || model == null) return;
        
        model.Id = meeting.MeetingId;
        model.Date = meeting.Date;
        model.Description = meeting.Description;
        model.Language = meeting.Language;
        model.Location = meeting.Location;
    }
    
    public static MeetingViewModel ToViewModel(this Meeting? meeting, User? user)
    {
        if (meeting == null)
            return null!;
        
        return new MeetingViewModel
        {
            MeetingId = meeting.Id,
            Date = meeting.Date,
            Description = meeting.Description,
            Language = meeting.Language,
            Location = meeting.Location,
        };
    }
}