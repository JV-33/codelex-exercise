namespace Exercise_2
{
    class CheckOddEven
    {
        static void Main(string[] args)
        {
            int number = 3;

            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.ReadKey();

            Console.WriteLine("bye!");
        }
    }
}
