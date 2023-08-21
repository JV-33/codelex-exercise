namespace Exercise3;

class Program
{

    static void Main(string[] args)
    {
        Student student = new Student(12)
        {
            FirstName = "Janis",
            LastName = "Kalnins",
            Address = "Brīvības gatve 222",
            ID = 2

        };

        Employee employee = new Employee("pirtnieks")
        {
            FirstName = "Gatis",
            LastName = "Liepa",
            Address = "Satekas iela 33",
            ID = 3
        };

        student.Display();
        Console.WriteLine("--------------------");
        employee.Display();
        Console.ReadKey();
    }
}

