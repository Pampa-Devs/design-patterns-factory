using DesignPatterns.Factory.Characters;

namespace DesignPatterns.Factory.Factories
{
    public class MageFactory : ICharacterFactory
    {
        private const int Health = 25;
        private const int Mana = 100;

        public Character Create(string name)
        {
            return new Mage(name, Health, Mana);
        }
    }
}
