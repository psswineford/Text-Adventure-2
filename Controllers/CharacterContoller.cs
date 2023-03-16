using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Text_Adventure_2.Models;
using Text_Adventure_2.Services.CharacterService;
using Text_Adventure_2.Services.UserService;

namespace Text_Adventure_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterContoller : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterContoller(ICharacterService characterService)
        {
            _characterService = characterService;
        }



        [HttpGet]
        public async Task<ActionResult<List<Characters>>> GetAllCharacters()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("id")]
        public async Task<ActionResult<List<Characters>>> GetCharactersByUserId(int id)
        {
            return Ok(await _characterService.GetCharactersByUserId(id));
        }



        [HttpPost]
        public async Task<ActionResult<List<Characters>>> AddCharacter(Characters character)
        {
            return Ok(await _characterService.AddCharacter(character));
        }


    }
}
