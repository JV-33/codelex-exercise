namespace ex5;

class Program
{
    static void Main(string[] args)
    {
        string class1 = "Literatūra";
        string class2 = "Bioloģija";
        string class3 = "Algebra";
        string class4 = "Vēsture";
        string class5 = "Fizika";

        string teacher1 = "Mr. Kalnins";
        string teacher2 = "Ms. Berzina";
        string teacher3 = "Mr. Ozolions";
        string teacher4 = "Mr. Lapins";
        string teacher5 = "Mr. Tarpins";

        Console.WriteLine("+" + new string('-', 51) + "+");
        Console.WriteLine("| {0, -2} | {1, -26} | {2, -15} |", "No", "Class", "Teacher");
        Console.WriteLine("| {0, -2} | {1, -26} | {2, -15} |", "--", new string('-', 26), new string('-', 15));
        Console.WriteLine("| {0, -2} | {1, -26} | {2, -15} |", "1", class1, teacher1);
        Console.WriteLine("| {0, -2} | {1, -26} | {2, -15} |", "2", class2, teacher2);
        Console.WriteLine("| {0, -2} | {1, -26} | {2, -15} |", "3", class3, teacher3);
        Console.WriteLine("| {0, -2} | {1, -26} | {2, -15} |", "4", class4, teacher4);
        Console.WriteLine("| {0, -2} | {1, -26} | {2, -15} |", "5", class5, teacher5);
        Console.WriteLine("+" + new string('-', 51) + "+");

        Console.ReadKey();
    }
}