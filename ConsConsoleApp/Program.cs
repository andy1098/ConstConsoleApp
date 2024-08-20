internal class Program
{
    private static void Main(string[] args)
    {
        string MyName = "Jane";
        byte MyAge = 27;
        bool HaveIApet = true;
        double MyShoeSize = 37.5;

        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("MyAge " + MyAge);
        Console.WriteLine("Do I have a pet? " + HaveIApet);
        Console.WriteLine("My shoe size is " + MyShoeSize);
        Console.WriteLine();

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        Console.Write("What is your favorite day of week? ");
        day_of_week dt  = (day_of_week) int.Parse(Console.ReadLine());
        Console.Write("Your favorite day of week is {0}", dt);
        Console.ReadKey();
    }
}

enum day_of_week : byte
    { понедельник = 1, вторник, среда, четверг, пятница, суббота, воскресенье }