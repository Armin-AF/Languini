using System.ComponentModel.DataAnnotations;

namespace LanguageFika.Api.Models;

public class Meeting
{
    [Key]
    public Guid Id { get; set; }
    [DataType(DataType.Date)]
    public DateTime? Date { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public Language? Language { get; set; }
}