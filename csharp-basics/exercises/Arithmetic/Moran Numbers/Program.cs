namespace Moran_Numbers
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static string Moran(int number)
        {
            int sum = 0, n = number;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }

            if (number % sum == 0)
            {
                if (IsPrime(number / sum))
                    return "M";
                else
                    return "H";
            }
            else
                return "Neither";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lūdzu ievadiet savu skaitli, lai uzzinātu kāds tas ir:  ");

            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                Console.WriteLine(Moran(userInput));
            }
            else
            {
                Console.WriteLine("Nederīga ievade. Lūdzu, ievadiet derīgu skaitli.");
            }

            Console.ReadKey();
        }
    }
}
