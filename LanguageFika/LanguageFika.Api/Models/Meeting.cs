using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageFika.Api.Models;

public class Meeting
{
    [Key]
    public Guid Id { get; set; }
    [DataType(DataType.Date)]
    public DateTime? Date { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public string? Language { get; set; }
    
    public string? CreatorEmail { get; set; }
}