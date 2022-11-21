namespace LanguageFika.Api.Models.ViewModels;

public class UserViewModel
{
    public string FirstName{ get; set; }
    public string LastName{ get; set; }
    public string Email{ get; set; }
    public string PhoneNumber{ get; set; }
    

    public List<Language> LearningLanguages{ get; set; }
    
    public List<Language> TeachingLanguages{ get; set; }
    

    public string FullName => $"{FirstName} {LastName}";

    public string FullContact => $"{PhoneNumber}, {Email}";

    public string FullLanguages => $"{string.Join(", ", LearningLanguages.Select(x => x.Name))}, {string.Join(", ", TeachingLanguages.Select(x => x.Name))}";
    
}