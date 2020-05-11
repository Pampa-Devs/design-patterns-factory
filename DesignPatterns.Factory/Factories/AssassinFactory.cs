using DesignPatterns.Factory.Characters;

namespace DesignPatterns.Factory.Factories
{
    public class AssassinFactory : ICharacterFactory
    {
        private const int Health = 75;
        private const int Mana = 25;

        public Character Create(string name)
        {
            return new Assassin(name, Health, Mana);
        }
    }
}
