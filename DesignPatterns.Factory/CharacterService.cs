using DesignPatterns.Factory.Characters;
using DesignPatterns.Factory.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class CharacterService
    {
        private readonly Dictionary<ECharacterType, ICharacterFactory> _characterFactories;

        public CharacterService(Dictionary<ECharacterType, ICharacterFactory> characterFactories)
        {
            _characterFactories = characterFactories;
        }

        public Character CreateCharacter(string name, ECharacterType characterType)
        {
            if (!_characterFactories.ContainsKey(characterType))
            {
                throw new ArgumentException($"Character Type is not implemented: {characterType}");
            }
            return _characterFactories[characterType].Create(name);
        }
    }
}
