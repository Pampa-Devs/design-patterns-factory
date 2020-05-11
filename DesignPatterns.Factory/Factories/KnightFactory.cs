using DesignPatterns.Factory.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory.Factories
{
    public class KnightFactory : ICharacterFactory
    {
        private const int Health = 100;
        private const int Mana = 0;

        public Character Create(string name)
        {
            return new Knight(name, Health, Mana);
        }
    }
}
