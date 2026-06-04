using System.Collections.Generic;
using WebInterface.API.Models;

namespace WebInterface.API
{
    public class InfoStore
    {
        public List<AnimeDto> AnimeList { get; set; }

        public static InfoStore Active { get; } = new InfoStore();


        public InfoStore()
        {
            AnimeList = new List<AnimeDto>()
            {
                new AnimeDto()
                {
                    Id = 1,
                    Name = "D.Gray-man",
                    Description = "Shonen supernatural action",
                    Characters = new List<CharacterDto>()
                    {
                        new CharacterDto()
                        {
                            Id = 1,
                            Name = "Allen Walker",
                            Description = "Youthful protagonist"
                        },
                        new CharacterDto()
                        {
                            Id = 2,
                            Name = "Millenium Earl",
                            Description = "Main villain"
                        }
                    }
                },
                new AnimeDto()
                {
                    Id = 2,
                    Name = "Boku no Hero Academia",
                    Description = "shonen superhero action",
                    Characters = new List<CharacterDto>()
                    {
                        new CharacterDto()
                        {
                            Id = 1,
                            Name = "Midoriya",
                            Description = "Naive hopeful hero"
                        },
                        new CharacterDto()
                        {
                            Id = 2,
                            Name = "Bakugo",
                            Description = "Violent anti-hero"
                        },
                        new CharacterDto()
                        {
                            Id = 3,
                            Name = "Ochako",
                            Description = "Supportive love interest"
                        }
                    }
                }
            };
        }
    }
}
