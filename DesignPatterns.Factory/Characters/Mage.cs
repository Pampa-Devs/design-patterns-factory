using System;

namespace DesignPatterns.Factory.Characters
{
    public class Mage : Character
    {
        public Mage(string name, int health, int mana)
        {
            Type = ECharacterType.Mage;

            Name = name;
            Health = health;
            Mana = mana;
        }

        public override void Attack()
        {
            // lógica de ataque
            Console.WriteLine("Mage atacou");
        }
    }
}
