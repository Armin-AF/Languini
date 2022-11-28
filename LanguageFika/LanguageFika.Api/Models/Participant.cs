using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageFika.Api.Models;

public class Participant
{
    [Key]
    public Guid ParticipantId { get; set; }
    
    [Required]
    public string? ParticipantEmail { get; set; }
    
    public Guid MeetingId { get; set; }

}