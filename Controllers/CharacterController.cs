using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Text_Adventure_2.Models;
using Text_Adventure_2.Services.CharacterService;

namespace Text_Adventure_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService) 
        {
            _characterService = characterService;
        }


        [HttpGet("userId")]
        public async Task<ActionResult<List<Characters>>> GetCharactersByUserId(int userId)
        {
            return Ok(await _characterService.GetCharactersByUserId(userId));
        }

        [HttpGet("id")]
        public async Task<ActionResult<List<Characters>>> GetSelectedCharacter(int id)
        {
            return Ok(await _characterService.GetSelectedCharacter(id));
        }





        [HttpPost("add")]
        public async Task<ActionResult<List<Characters>>> AddCharacter(Characters character)
        {
            return Ok(await _characterService.AddCharacter(character));
        }

        [HttpPut]
        public async Task<ActionResult<List<Characters>>> UpdateCharacters(Characters updateCharacter)
        {
            var response = await _characterService.UpdateCharacters(updateCharacter);
            if(response == null)
            {
                return BadRequest("No Character found");
            }

            return Ok(response);
        }

        [HttpDelete("charId")]
        public async Task<ActionResult<Characters>> DeleteCharacter(int id)
        {
            return Ok(await _characterService.DeleteCharactersByID(id));
        }

    }
}
