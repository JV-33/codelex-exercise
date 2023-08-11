namespace Exercise6;

class Piglet
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Piglet!");
        Console.WriteLine("Uzmet kauliņu, lai iegūtu lielāko summu!!");
        Console.WriteLine("Spied Enter, lai sāktu mest ");
        Console.ReadKey();
        Random random = new Random();
        

        int punkti = 0;
        bool mestVēlreiz = true;


        while (mestVēlreiz)
        {
            int randomSkaitlis = random.Next(1, 7);
            Console.WriteLine($"Jūs uzmetāt : {randomSkaitlis}");

            if (randomSkaitlis == 1)
            {
                Console.WriteLine("Spēle beigusies! Jūsu punktu sakits ir 0");
                mestVēlreiz = false;
            }
            else
            {
                punkti += randomSkaitlis;
                Console.WriteLine($"Jūsu punktu skaits ir : {punkti}");
                Console.WriteLine("Mest vēlreiz? (Jā/Nē)");
                string izvele = Console.ReadLine().ToLower();
                if (izvele == "nē")
                {
                    mestVēlreiz = false; 
                    Console.WriteLine($"Jūsu punktu skaits ir : {punkti}");
                }




            }
        }
        Console.ReadKey();
    }
}

