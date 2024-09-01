internal class Program
{
    // (string name, string surname, string login, int login_count, int age, bool has_pet, string[] colors) anketa;

    private static void Main(string[] args)
    {
        
    }

    static object EnterData()
    {
        Console.Write("Введите имя:");
        var name = Console.ReadLine();
        Console.Write("Введите фамилию:");
        var surname = Console.ReadLine();
        Console.Write("Введите возраст пользователя: ");
        var age = int.Parse(Console.ReadLine()); // нужна проверка

        Console.Write("У Вас есть домашний питомец? ");
        bool has_pet = Console.ReadLine() == "да" ? true : false;

        Console.Write("Укажите количество домашних питомцев - ");
        var petn = Console.ReadLine();

        int petnum = 0;
        do
            if (!int.TryParse(petn, out petnum))
            {
                Console.WriteLine("Некорректное значение, введите целое положительное число - ");
                petn = Console.ReadLine();
            }
        while (petnum == 0);

        string[] colors = new string[3];
        Console.WriteLine("Введите три любимых цвета пользователя");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Введите цвет: ");
            var colors[i] = Console.ReadLine();
        }

        return (name, surname, login, age, has_pet, colors);
    
        
    }
}