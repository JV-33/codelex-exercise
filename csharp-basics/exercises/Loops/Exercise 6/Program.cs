namespace FizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lūdzu ievadiet vesalu skaitli!");

       int input =  Convert.ToInt32(Console.ReadLine());

        int skaititajs = 0; 

     
        for (int i = 1; i <= input; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            else
            {
                Console.Write(i+ " ");
            }
            skaititajs++;

            if (skaititajs == 20 )
            {
                Console.WriteLine();
                skaititajs = 0;
            }
        }
        
        Console.ReadKey();

    }
}