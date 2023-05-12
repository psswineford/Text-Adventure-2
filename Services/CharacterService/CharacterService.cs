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
            try
            {
                _context.Characters.Add(character);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return await GetCharactersByUserId(character.UserId);
        }

        public async Task<List<Characters>> GetCharactersByUserId(int userId)
        {
            var characterList = await _context.Characters
                .Where(x => x.UserId == userId)
                .ToListAsync();

            return characterList;
        }

        public async Task<List<Characters>> GetSelectedCharacter(int id)
        {
            var selectedCharacter = await _context.Characters
                .Where(x => x.Id == id)
                .ToListAsync();

            return selectedCharacter;
        }

        public async Task<List<Characters>> UpdateCharacters(Characters updateCharacter)
        {
            var currentCharacter = await _context.Characters.SingleAsync(c => c.Id == updateCharacter.Id);

            currentCharacter.Type = updateCharacter.Type;
            currentCharacter.Name = updateCharacter.Name;
            currentCharacter.ArmorClass = updateCharacter.ArmorClass;
            currentCharacter.HitPoints = updateCharacter.HitPoints;
            currentCharacter.CurrentRoom = updateCharacter.CurrentRoom;
            currentCharacter.HasRing = updateCharacter.HasRing;
            currentCharacter.HasJewel = updateCharacter.HasJewel;   
            currentCharacter.HasSword = updateCharacter.HasSword;
            currentCharacter.UserId = updateCharacter.UserId;
           // _context.Characters.Update(currentCharacter);    look into update
            await _context.SaveChangesAsync();
            return await GetCharactersByUserId(updateCharacter.UserId);
        }   
    }
}
