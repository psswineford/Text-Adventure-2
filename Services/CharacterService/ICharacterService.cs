﻿using System.Threading.Tasks;
using Text_Adventure_2.Models;

namespace Text_Adventure_2.Services.CharacterService
{
    public interface ICharacterService
    {

        Task<List<Characters>> AddCharacter(Characters character);
        Task<List<Characters>> GetCharactersByUserId(int id);
        Task<List<Characters>> UpdateCharacters(Characters updateCharacter);
        Task<List<Characters>> GetSelectedCharacter(int id);
        Task<Characters> DeleteCharactersByID(int id);
    }
}

