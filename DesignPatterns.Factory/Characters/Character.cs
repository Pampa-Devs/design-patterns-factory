using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory.Characters
{
    public abstract class Character
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Mana { get; protected set; }
        public ECharacterType Type { get; protected set; }

        public abstract void Attack();
    }
}
