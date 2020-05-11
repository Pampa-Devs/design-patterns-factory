using System;

namespace DesignPatterns.Factory.Characters
{
    public class Ranger : Character
    {
        public Ranger(string name, int health, int mana)
        {
            Type = ECharacterType.Ranger;

            Name = name;
            Health = health;
            Mana = mana;
        }

        public override void Attack()
        {
            // lógica de ataque
            Console.WriteLine("Ranger atacou");
        }
    }
}
