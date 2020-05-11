using DesignPatterns.Factory.Characters;
using DesignPatterns.Factory.Factories;
using System;
using System.Collections.Generic;
using Xunit;

namespace DesignPatterns.Factory.Tests
{
    public class CharacterTests
    {
        private readonly CharacterService _characterService;

        public CharacterTests()
        {
            var characterFactories = new Dictionary<ECharacterType, ICharacterFactory>()
            {
                { ECharacterType.Knight, new KnightFactory() },
                { ECharacterType.Mage, new MageFactory() },
                { ECharacterType.Ranger, new RangerFactory() },
                { ECharacterType.Assassin, new AssassinFactory() },
            };

            _characterService = new CharacterService(characterFactories);
        }

        [Fact]
        public void CreateCharacter_WhenKnight_ShouldReturnHealth100_AndMana0_AndTypeKnight()
        {            
            var character = _characterService.CreateCharacter("Felipe", ECharacterType.Knight);

            Assert.Equal(100, character.Health);
            Assert.Equal(0, character.Mana);
            Assert.Equal(ECharacterType.Knight, character.Type);
        }

        [Fact]
        public void CreateCharacter_WhenMage_ShouldReturnHealth25_AndMana100_AndTypeMage()
        {
            var character = _characterService.CreateCharacter("Eduardo", ECharacterType.Mage);

            Assert.Equal(25, character.Health);
            Assert.Equal(100, character.Mana);
            Assert.Equal(ECharacterType.Mage, character.Type);
        }

        [Fact]
        public void CreateCharacter_WhenRanger_ShouldReturnHealth50_AndMana50_AndTypeRanger()
        {
            var character = _characterService.CreateCharacter("Lucas", ECharacterType.Ranger);

            Assert.Equal(50, character.Health);
            Assert.Equal(50, character.Mana);
            Assert.Equal(ECharacterType.Ranger, character.Type);
        }

        [Fact]
        public void CreateCharacter_WhenAssassin_ShouldReturnHealth75_AndMana25_AndTypeAssassin()
        {
            var character = _characterService.CreateCharacter("Bob o Assassino", ECharacterType.Assassin);

            Assert.Equal(75, character.Health);
            Assert.Equal(25, character.Mana);
            Assert.Equal(ECharacterType.Assassin, character.Type);
        }

        [Fact]
        public void CreateCharacter_WhenInvalidType_ShouldThrowException()
        {
            Assert.Throws<ArgumentException>(() => _characterService.CreateCharacter("Felipe", ECharacterType.None));
        }
    }
}
