using System.ComponentModel.DataAnnotations;

namespace LanguageFika.Api.Models;

public class Language
{
    [Key]
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Level { get; set; }
    
    public string? UserId { get; set; }
    public virtual User? User { get; set; }
}