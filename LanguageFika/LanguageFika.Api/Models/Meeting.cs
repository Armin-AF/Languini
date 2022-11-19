using System.ComponentModel.DataAnnotations;

namespace LanguageFika.Api.Models;

public class Meeting
{
    [Key]
    public Guid MeetingId { get; set; }
    [DataType(DataType.Date)]
    public DateTime? Date { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public string? Language { get; set; }

    public string? UserId { get; set; }
    public virtual User? User { get; set; }
}