using System.ComponentModel.DataAnnotations;

namespace WebInterface.API.Models
{
    public class CharacterCreationDto
    {
        [Required(ErrorMessage = "No nameless characters")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(250)]
        public string? Description { get; set; }

    }
}
