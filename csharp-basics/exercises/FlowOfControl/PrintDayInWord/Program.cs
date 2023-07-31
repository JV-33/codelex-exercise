namespace PrintDayInWord;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ievadi skaitli no 0-6 : ");
        int input = int.Parse(Console.ReadLine());

        if (input == 0)
        {
            Console.WriteLine("Pirmdiena");
        }
        else if (input == 1)
        {
            Console.WriteLine( "Otradiena");
        }
        else if (input == 2)
        {
            Console.WriteLine("Trešdiena");
        }
        else if (input == 3)
        {
            Console.WriteLine("Ceturdiena");
        }
        else if (input == 4)
        {
            Console.WriteLine("Piekdiena");
        }
        else if (input == 5)
        {
            Console.WriteLine("Sestdiena");
        }
        else if (input == 6)
        {
            Console.WriteLine("Svētdiena");
        }
        else
        {
            Console.WriteLine("Nav atbilstoš skaitlis kādai dienai!!!");
        }
        


        Console.WriteLine("Ievadi skaitli no 0-6 : ");
        int input1 = int.Parse(Console.ReadLine());

        switch (input1)
            {
            case 0:
                Console.WriteLine("Pirmdiena");
                break;
            case 1:
                Console.WriteLine("Otradiena");
                break;
            case 2:
                Console.WriteLine("Trešdiena");
                break;
            case 3:
                Console.WriteLine("Ceturdiena");
                break;
            case 4:
                Console.WriteLine("Piekdiena");
                break;
            case 5:
                Console.WriteLine("Sestdiena");
                break;
            case 6:
                Console.WriteLine("Svētdiena");
                break;
            default:
                Console.WriteLine("Nav atbilstoš skaitlis kādai dienai!!!");
                break;

        }
        Console.ReadKey();  
    }
}

