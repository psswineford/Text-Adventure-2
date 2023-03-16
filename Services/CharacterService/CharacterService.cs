using Microsoft.EntityFrameworkCore;
using Text_Adventure_2.Data;
using Text_Adventure_2.Models;

namespace Text_Adventure_2.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly DataContext _context;

        public CharacterService(DataContext context)
        {
            _context = context;
        }


        public async Task<List<Characters>> AddCharacter(Characters character)
        {
            _context.Characters.Add(character);
            await _context.SaveChangesAsync();
            return await GetAllCharacters();
        }

        public async Task<List<Characters>> GetAllCharacters()
        {
            var characterList = await _context.Characters.ToListAsync();    
            return characterList;
        }

        public async Task<List<Characters>> GetCharactersByUserId(int id)
        {
            var characterList = await _context.Characters
                .Where(x => x.UserId == id)
                .ToListAsync();

            return characterList;
        }
    }
}
