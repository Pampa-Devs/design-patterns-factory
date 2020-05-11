using DesignPatterns.Factory.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory.Factories
{
    public interface ICharacterFactory
    {
        Character Create(string name);
    }
}
