using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using WebInterface.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebInterface.API.Controllers
{
    [Route("api/anime")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        // GET: api/anime
        [HttpGet]
        public ActionResult<IEnumerable<AnimeDto>> GetAllAnime()
        {
            return Ok(InfoStore.Active.AnimeList);
        }


        [HttpGet("{id}")]
        public ActionResult<AnimeDto> GetAnime(int id) 
        { 

            var animeFound = InfoStore.Active.AnimeList.FirstOrDefault(anime => anime.Id == id);

            if (animeFound == null) { return NotFound(); }

            return Ok(animeFound);
        }
    }
}
