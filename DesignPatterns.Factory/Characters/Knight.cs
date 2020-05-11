using System;

namespace DesignPatterns.Factory.Characters
{
    public class Knight : Character
    {
        public Knight(string name, int health, int mana)
        {
            Type = ECharacterType.Knight;

            Name = name;
            Health = health;
            Mana = mana;
        }

        public override void Attack()
        {
            // lógica de ataque
            Console.WriteLine("Knight atacou");
        }
    }
}
