using System.ComponentModel.DataAnnotations;

namespace LanguageFika.Api.Models;

public class Address
{
    [Key]
    public Guid AddressId { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }
    
    public Guid UserId { get; set; }
    public User? User { get; set; }
}