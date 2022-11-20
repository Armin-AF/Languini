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

    public string? PhoneNumber { get; set; }
   
    public string? ProfilePicture { get; set; }
    public string? Description { get; set; }
    
    public string? LanguageToLearn { get; set; }

    public Guid AddressId { get; set; }
    public virtual Address? Address{ get; set; }
    
    public Guid LanguageId { get; set; }
    public virtual ICollection<Language>? Languages { get; set; }

    public Guid MeetingId { get; set; }
    public virtual ICollection<Meeting>? Meetings { get; set; }
    
    
}