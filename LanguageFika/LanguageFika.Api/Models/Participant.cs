using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanguageFika.Api.Models;

public class Participant
{
    [Key]
    public string Id { get; set; } = String.Empty;
    
}