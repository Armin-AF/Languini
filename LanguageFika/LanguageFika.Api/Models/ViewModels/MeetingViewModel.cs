namespace LanguageFika.Api.Models.ViewModels;

public class MeetingViewModel
{
    public Guid MeetingId { get; set; }
    public DateTime? Date { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public string? Language { get; set; }
}