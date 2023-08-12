namespace Exercise_6;

class DogTest
{
    private Dog max;
    private Dog rocky;
    private Dog sparky;
    private Dog buster;
    private Dog sam;
    private Dog lady;
    private Dog molly;
    private Dog coco;

    public DogTest()
    {
        max = new Dog("Max", "male");
        rocky = new Dog("Rocky", "male");
        sparky = new Dog("Sparky", "male");
        buster = new Dog("Buster,", "male");
        sam = new Dog("Sam", "male");
        lady = new Dog("Lady", "female");
        molly = new Dog("Molly", "female");
        coco = new Dog("Coco", "female");

        max.Father = rocky;
        max.Mother = lady;
        coco.Father = buster;
        coco.Mother = molly;
        rocky.Father = sam;
        rocky.Mother = molly;
        buster.Father = sparky;
        buster.Mother = lady;
    }

    static void Main(string[] args)
    {
        DogTest test = new DogTest();

        Console.WriteLine($"Coco's father's name is: {test.coco.GetFatherName()}");
        Console.WriteLine($"Sparky's father's name is: {test.sparky.GetFatherName()}");

        if (test.coco.HasSameMotherAs(test.rocky))
        {
            Console.WriteLine("Coco and Rocky have the same mother.");
        }
        Console.ReadKey();
    }
}
