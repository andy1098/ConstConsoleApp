internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");
        // var str = Console.ReadLine();
        Console.WriteLine("Укажите глубину эха");
        // var deep = int.Parse(Console.ReadLine());

        Console.WriteLine(PowerUp(0, 9));
        // Echo(str, deep);
        Console.ReadKey();
    }

    static void Echo(string saidworld, int deep)
    {
        var modif = saidworld;
        if (modif.Length > 2) 
            modif = modif.Remove(0, 2);
        Console.BackgroundColor = (ConsoleColor)deep;
        Console.WriteLine("... " + modif);
        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
    }
    static int PowerUp(int N, byte pow)
    {
        if (N == 0 & pow == 0) return 0;
        if (N == 0 | pow == 0) return 1;
        else
        {
            if (pow == 1) return N;
            else
                return N = N * PowerUp(N, --pow);
        }
    }
}