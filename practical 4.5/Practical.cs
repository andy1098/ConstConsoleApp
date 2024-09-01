internal class Practical
{
    static void ReturnColor(string name, string[] colors)
    {
        //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        //var color = Console.ReadLine();
        for (int i = 0; i<colors.Length; i++)
        switch (colors[i])
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine(name + " Ваш цвет красный!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine(name + " Ваш цвет зеленый!");
                break;

            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(name + " Ваш цвет голубой!");
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(name + " Ваш цвет адски непонятный!");
                break;
        }
        // return colors;
    }
    private static void Main(string[] args)
    {
        (string name, string surname, string login, int login_count, int age, bool has_pet, string[] colors) anketa;
        //for (int j = 0; j < 3; j++)
        
            Console.Write("Введите имя:");
            anketa.name = Console.ReadLine();
            Console.Write("Введите фамилию:");
            anketa.surname = Console.ReadLine();
            Console.Write("Введите логин:");
            anketa.login = Console.ReadLine();
            anketa.login_count = anketa.login.Length;
            Console.Write("У Вас есть домашний питомец? ");
            anketa.has_pet = Console.ReadLine() == "да" ? true : false;
            Console.Write("Введите возраст пользователя: ");
            anketa.age = int.Parse(Console.ReadLine());
            anketa.colors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите цвет: ");
                anketa.colors[i] = Console.ReadLine();
            }
        

        ReturnColor(anketa.name, anketa.colors);
    }
}