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
                "Suns",
                "Maize",
                "Valmiera",
                "Zieds"
            };
            var allowedMisses = 5;
            var missedLetters = string.Empty;
            var word = words[random.Next(words.Count)];
            var wordForDisplay = new string('_', word.Length).ToCharArray();
            while (wordForDisplay.Contains('_') && allowedMisses > 0)
            {
                Console.WriteLine("Guess the word.");
                Console.WriteLine($"Word: {new string(wordForDisplay)}");
                Console.WriteLine($"Misses: {missedLetters}");
                Console.Write("Guess:");
                var input = Console.ReadKey();
                Console.WriteLine();
                //todo: validate input
                // vai burts ir.
                var regex = new Regex(pattern: "[a-zA-Z]");
                // TODO: validate using the regex and do the game logic.
            }
        }
    }
}
