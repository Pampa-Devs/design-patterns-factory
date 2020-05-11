using DesignPatterns.Factory.Characters;

namespace DesignPatterns.Factory.Factories
{
    public class RangerFactory : ICharacterFactory
    {
        private const int Health = 50;
        private const int Mana = 50;

        public Character Create(string name)
        {
            return new Ranger(name, Health, Mana);
        }
    }
}
