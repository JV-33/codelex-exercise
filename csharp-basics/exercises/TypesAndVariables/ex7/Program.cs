namespace ex7;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ieraksti kādu tekstu lai uzzinātu no cik skaitļiem tas sastāv");
        
        string userInput = Console.ReadLine();

        int beginingNumber = 0;

        foreach (char c in userInput)
        {
            beginingNumber++;
        }


        Console.WriteLine($"Jūsu uzrakstītajā ir {beginingNumber}");

        Console.ReadKey();
    }
}

