/*
 * Student ID : 1690704125
 * Name       : Assignment01
 * Section    : 129D
 * No.        : 11
 * Course     : GI113 Computer Programming (GI)
 */
using System.ComponentModel.DataAnnotations;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Forsaken";
            const string Survivor = "Survivor";
            const int MaxLevel = 100;

            var survivorName = "Elliot";
            var survivorRole = "Healer";
            char survivorRank = 'A';
            int survivorLevel = 1;
            int survivormaxHp = 80;
            int regularSpeed = 12;
            float sprintingSpeed = 26.5f;
            double maxStamina = 100.6;
            bool isPlayable = true;

            Console.WriteLine($"=====+ {GameTitle} +=====");
            Console.WriteLine($"\n===== {Survivor} =====");
            Console.WriteLine($"Name            : {survivorName}");
            Console.WriteLine($"Role            : {survivorRole}");
            Console.WriteLine($"Rank            : {survivorRank}");
            Console.WriteLine($"Level           : {survivorLevel} / {MaxLevel}");
            Console.WriteLine($"Health          : {survivormaxHp}");
            Console.WriteLine($"Regular Speed   : {regularSpeed}");
            Console.WriteLine($"Sprinting Speed : {sprintingSpeed}");
            Console.WriteLine($"Max Stamina     : {maxStamina}");
            Console.WriteLine($"Playable        : {isPlayable}");

            // Implicit Conversion
            double hpAsDouble = survivormaxHp;
            Console.WriteLine($"\nHP as double (implicit)  : {hpAsDouble}");


            // Explicit Cast
            int staminaCast = (int)maxStamina;

            // Convert.ToInt32()
            int staminaConverted = Convert.ToInt32(maxStamina);

            Console.WriteLine($"Stamina cast (truncates) : {staminaCast}");
            Console.WriteLine($"Stamina Convert (rounds) : {staminaConverted}");

            const string ElliotSkills = "Skills";

            Console.WriteLine($"\n=====+ {ElliotSkills} +=====");
            Console.WriteLine("Pizza Throw : Heal other survivors");
            Console.WriteLine("Rush Hour   : Gain Speed");

        }
    }
}
