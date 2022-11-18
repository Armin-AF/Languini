using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LanguageFika.Api.Models;

public class User
{
    [Key]
    public Guid UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    [DataType(DataType.Date)]
    public DateTime? BirthDate { get; set; }
    public string? Email { get; set; }
    
    public Guid AddressId { get; set; }
    public Address? Address{ get; set; }

    public string? PhoneNumber { get; set; }
    // Profile picture //TODO make it a byte array
    public Guid? ProfilePictureId { get; set; }
    public Picture? ProfilePicture { get; set; }
    public string? Description { get; set; }
    public string? LanguageToLearn { get; set; }
    public string? LanguageToTeach { get; set; }
    public string? Password { get; set; }
    // password reset token
    public string? Token { get; set; }
    // password reset token expiration date
    [DataType(DataType.Date)]
    public DateTime? TokenExpiration { get; set; }
    
    public Guid LanguageId { get; set; }
    public ICollection<Language>? Languages { get; set; }

    public ICollection<Meeting>? Meetings { get; set; }
    


}