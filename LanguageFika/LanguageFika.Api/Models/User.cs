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
    
    public Language LanguageToLearn { get; set; }
    public Language LanguageToTeach { get; set; }

   public string? StreetAddress { get; set; }
   public string? City { get; set; }
   public string? Country { get; set; }
   public string? PostalCode { get; set; }
}