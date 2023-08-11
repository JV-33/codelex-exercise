using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Es domāju par skaitli no 1 līdz 100");


            while (true)
            {

                string userInput = Console.ReadLine();

                if (!int.TryParse(userInput, out int userGuess))
                {
                    Console.WriteLine($"Atvaino, bet tas nav skaitlis. Es domāju par {randomNumber}.");
                    break;

                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine($"Domāji par aukstu, mini ko mazāku. Es domāju par {randomNumber}.");
                    break;
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine($"Domāji par zemu, mini augtāk. Es domāju par {randomNumber}.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Uzminēji!!! Mans skaitlis bija {randomNumber}");
                    break;
                }
                
            }
            Console.ReadKey();
        }

    }
}
