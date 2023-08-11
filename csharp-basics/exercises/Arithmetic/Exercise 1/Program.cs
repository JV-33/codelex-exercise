namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 2;
            int second = 5;

            int sum = first + second;
            int div = Math.Abs(first - second);

            if (first == 15 || second == 15 || sum == 15 || div == 15)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
        }
    }
}
