using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var words = new List<string>
            {
                "valrieksts",
                "Laterna",  
                "Kopsavilkums",
                "Armagidons"
            };
            var allowedMisses = 5;
            var missedLetters = string.Empty;
            var word = words[random.Next(words.Count)];
            var wordForDisplay = new string('_', word.Length).ToCharArray();
            while (wordForDisplay.Contains('_') && allowedMisses > 0)
            {
                Console.WriteLine("Uzmini vārdu.");
                Console.WriteLine($"Vārds: {new string(wordForDisplay)}");
                Console.WriteLine($"Kļūdas: {missedLetters}");
                Console.Write("Minējums:");
                var input = Console.ReadKey();
                Console.WriteLine();
                char minetaisBurts = char.ToLower(input.KeyChar);
                string mazajosBurtos = word.ToLower();

                if (mazajosBurtos.Contains(minetaisBurts))
                var regex = new Regex(pattern: "[a-zA-Z]");
                // TODO: validate using the regex and do the game logic.
            }
        }
    }
}
