using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebInterface.API.Models;

namespace WebInterface.API.Controllers
{
    [Route("api/anime/{AnimeId}/characters")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CharacterDto>> GetCharacters(int AnimeId)
        {
            var animeFound = InfoStore.Active.AnimeList.FirstOrDefault(anime => anime.Id == AnimeId);

            if (animeFound == null) return NotFound();

            return Ok(animeFound.Characters);
        }


        [HttpGet("{charaId}")]
        public ActionResult<CharacterDto> GetCharacter(int AnimeId, int charaId)
        {
            var animeFound = InfoStore.Active.AnimeList.FirstOrDefault(anime => anime.Id == AnimeId);

            if (animeFound == null) return NotFound();

            var characterFound = animeFound.Characters.FirstOrDefault(chara => chara.Id == charaId);

            if (characterFound == null) return NotFound();

            return Ok(characterFound);
        }

        [HttpPost]
        public ActionResult<CharacterDto> AddCharacter(int AnimeId, CharacterCreationDto character)
        {
            var animeFound = InfoStore.Active.AnimeList.FirstOrDefault(anime => anime.Id == AnimeId);

            if (animeFound == null) return NotFound();

            var newId = animeFound.Characters.Max(cha => cha.Id) +1; //Gets the highest Id in the list and adds one

            CharacterDto completeChara = new CharacterDto()
            {
                Id = newId,
                Name = character.Name,
                Description = character.Description
            };

            animeFound.Characters.Add(completeChara);

            return Ok(completeChara);

        }
    }
}
