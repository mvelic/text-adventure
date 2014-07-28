using System;
using System.Collections.Generic;
using System.Text;

namespace Text_Adventure
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
            PlayerName = SetName();
            Gender = SetGender();
        }

        string SetGender()
        {
            Console.WriteLine("And what is your gender? (M or F)");
            string gen = Console.ReadLine();
            switch ( gen )
            {
                case "M":
                    string gender = "male";
                    return gender;
                case "F":
                    gender = "female";
                    return gender;
                default:
                    gender = "female";
                    return gender;
            }
        }

        string SetName()
        {
            Console.WriteLine("Please begin by selecting a name for your character:");
            string name = Console.ReadLine();
            return name;
        }

        // Properties
        public string PlayerName { get; set; }
        public string Gender { get; set; }
    }
}
