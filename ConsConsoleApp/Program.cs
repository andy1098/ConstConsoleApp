using System.Xml.Linq;

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
        String name = "Jane";
        Byte age = 27;
        String favcolor = "black";
        Console.WriteLine("{0} \n  {1} \n {2}", name, age, favcolor);
        Console.ReadLine();
    }

    enum Semaphore : short
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}

enum day_of_week : byte
    { понедельник = 1, вторник, среда, четверг, пятница, суббота, воскресенье }