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

        Console.WriteLine("Uzraksti tekstu ko vēlies uzzināt ciparu sistēmā :");

        var input1 = Console.ReadLine().ToUpper();
        StringBuilder result1 = new StringBuilder();

        foreach (char c in input1)
        {
            switch (c)
            {
                case 'A':
                case 'B':
                case 'C':
                    result1.Append('2');
                    break;
                case 'D':
                case 'E':
                case 'F':
                    result1.Append('3');
                    break;
                case 'G':
                case 'H':
                case 'I':
                    result1.Append('4');
                    break;
                case 'J':
                case 'K':
                case 'L':
                    result1.Append('5');
                    break;
                case 'M':
                case 'N':
                case 'O':
                    result1.Append('6');
                    break;
                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    result1.Append('7');
                    break;
                case 'T':
                case 'U':
                case 'V':
                    result1.Append('8');
                    break;
                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    result1.Append('9');
                    break;
                default:
                    result1.Append(c);
                    break;
            }
        }

        Console.WriteLine("Rezultāts: " + result1.ToString());
        Console.ReadLine();
    }
}

