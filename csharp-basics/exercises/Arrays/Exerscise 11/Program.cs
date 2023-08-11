using System;

namespace Exerscise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFindNemo();
            Console.ReadKey();

   
        }

        private static void TestFindNemo()
        {
            Console.WriteLine(FindNemo("I am finding Nemo !"));  
            Console.WriteLine(FindNemo("Nemo is me"));           
            Console.WriteLine(FindNemo("I Nemo am"));            
        }

        private static string FindNemo(string input)
        {
            string[] words = input.Split(new char[] { ' ', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Equals("Nemo", StringComparison.OrdinalIgnoreCase))
                {
                    return $"Es atrdu  Nemo  {i + 1}!";
                }
            }

            return "Es nevaru atrast Nemo :(";
        }
    }
}
