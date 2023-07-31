using System;
using System.Text;

namespace PhoneKeyPad;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Uzraksti tekstu ko vēlies uzzināt ciparu sistēmā :");

        var input = Console.ReadLine().ToUpper();
        StringBuilder result = new StringBuilder();

        foreach (var v in input)
        {
            if (v >= 'A' && v <= 'C') result.Append(2);
            else if (v >= 'D' && v <= 'F') result.Append('3');
            else if (v >= 'G' && v <= 'I') result.Append('4');
            else if (v >= 'J' && v <= 'L') result.Append('5');
            else if (v >= 'M' && v <= 'O') result.Append('6');
            else if (v >= 'P' && v <= 'S') result.Append('7');
            else if (v >= 'T' && v <= 'V') result.Append('8');
            else if (v >= 'W' && v <= 'Z') result.Append('9');
            else result.Append(v);
        }
        Console.WriteLine($"Iznākums {result}");
        Console.ReadLine();




    }
}

