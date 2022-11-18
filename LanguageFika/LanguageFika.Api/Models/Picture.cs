namespace LanguageFika.Api.Models;

public class Picture
{
    public Guid PictureId { get; set; }
    public string? PictureName { get; set; }
    public byte[]? PictureData { get; set; }
    
    public Guid UserId { get; set; }
    public User? User { get; set; }
}