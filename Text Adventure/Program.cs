using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Game!");
            
            PlayerCharacter PlayerCharacter = new PlayerCharacter();

            Console.WriteLine("That's cool. For reference, your character, {0}, is {1}.", PlayerCharacter.PlayerName, PlayerCharacter.Gender);

        }
    }
}
