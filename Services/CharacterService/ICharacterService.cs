using Text_Adventure_2.Models;

namespace Text_Adventure_2.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Characters>> GetAllCharacters();

        Task<List<Characters>> AddCharacter(Characters character);
        Task<List<Characters>> GetCharactersByUserId(int id);
    }
}

