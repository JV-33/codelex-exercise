namespace Exercise_10;

class NumberSquare
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ievadi mazāko veselu slkaitli");
        int input1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ievadi lielāko veselu slkaitli");
        int input2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Mazākais : {input1}");
        Console.WriteLine($"Lielākasi : {input2}");


        for (int i = input1; i <= input2 ; i++)
        {
            for(int j= i; j<= input2; j++)
            {
                Console.Write(j) ;
            }

            for (int k = input1; k < i; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
        }
        Console.ReadKey();

    }
}

