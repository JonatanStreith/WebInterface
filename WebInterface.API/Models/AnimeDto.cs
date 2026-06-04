using System.Collections.Generic;

namespace WebInterface.API.Models
{
    public class AnimeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ICollection<CharacterDto> Characters { get; set; } = new List<CharacterDto>();

    }
}
