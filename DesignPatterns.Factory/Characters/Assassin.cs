using System;

namespace DesignPatterns.Factory.Characters
{
    public class Assassin : Character
    {
        public Assassin(string name, int health, int mana)
        {
            Type = ECharacterType.Assassin;

            Name = name;
            Health = health;
            Mana = mana;
        }

        public override void Attack()
        {
            // lógica de ataque
            Console.WriteLine("Assassin atacou");
        }
    }
}
