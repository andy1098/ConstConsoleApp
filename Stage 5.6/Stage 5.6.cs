internal class Program
{
   
    private static void Main(string[] args)
    {
        string yn = "";
        do
        { 
            WriteTuple(EnterData());
            Console.WriteLine("--------------------------------------");
            Console.Write("Повторим? y/n: ");
            yn = Console.ReadLine();

            bool k = true;    
            while (k)
            {
                switch (yn)
                {
                    case "y":
                        k = false;
                        Console.WriteLine("--------------------------------------");
                        break;
                    case "n":
                        k = false;
                        break;
                    default:
                        Console.Write("Прошу ввести корректный ответ - y/n: ");
                        yn = Console.ReadLine();
                        break;
                }
            }
        }
        while (yn != "n");
    }

    // Вывод данных в консоль
    static void WriteTuple((string name, string surname, int age, bool has_pet, int numpet, string[] namespet, int numcolor, string[] colors) anketa)
    {
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Ваше имя и фамилия: " + anketa.name + " " + anketa.surname);
        Console.WriteLine("Вам {0} полных лет.", anketa.age);
        if (anketa.has_pet)
        {
            var i = 1;
            foreach (string name in anketa.namespet)
            {
                Console.WriteLine("Имя {0}-го питомца: {1};", i, name);
                i++;
            }
        }
        else
            Console.WriteLine("У пользователя нет домашних питомцев.");

        if (anketa.colors[0] != "")
        {
            var i = 1;
            foreach (string color in anketa.colors)
            {
                Console.WriteLine("Название {0}-го любимого цвета: {1};", i, color);
                i++;
            }
        }
        else
            Console.WriteLine("У пользователя нет любимых цветов.");
    }        
    static (string, string, int, bool, int, string[], int, string[]) EnterData() // Ввод данных
    {
        string[] colors, petsname;

        Console.Write("Введите имя: ");
        var name = Console.ReadLine();
        Console.Write("Введите фамилию: ");
        var surname = Console.ReadLine();
        Console.Write("Введите возраст пользователя: ");
        var age = ToInt();

        var petnum = 0;
        Console.Write("У Вас есть домашний питомец (да/нет)? ");
        
        //bool has_pet = Console.ReadLine() == "да" ? true : false;
        
        bool control = true;
        bool has_pet = true;
        while (control)
        {
            switch (Console.ReadLine())
            {
                case "да":
                    control = false;
                    break;
                case "нет":
                    control = false;
                    has_pet = false;
                    break;
                default:
                    Console.Write("Не понял, прошу ввести корректный ответ - да или нет: ");
                    break;
            }
        }
        
        if (has_pet)
        { 
            Console.Write("Укажите количество домашних питомцев: ");
            petnum = ToInt();
            petsname = GetArray(petnum, "Укажите имя домашнего питомца ");
        }
        else
        {
            petsname = new[] { "" };
        }

        Console.Write("Введите количество любимых цветов или 0 если отсутствуют: ");
        var numcolors = ToInt(0);
        if (numcolors != 0)
        {
            colors = GetArray(numcolors, "Введите любимый цвет #");
        }
        else
        {
            colors =  new[] { "" };
        }
        return (name, surname, age, has_pet, petnum, petsname, numcolors, colors);
    }
    static string[] GetArray(int num, string text) // заполняет массив 
    {
        var mas = new string[num];

        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write(text + "{0}: ", i + 1);
            mas[i] = Console.ReadLine();
        }
        return mas;
    }
    static int ToInt(int min = 1) // Проверка целого положительного числа
    {
        var petn = Console.ReadLine();
        bool is_int = false;
        int num = -1;
        do
        {
            if (!int.TryParse(petn, out num))
            {
                Console.Write("Некорректное значение, введите число: ");
                petn = Console.ReadLine();
            }
            else if (((num = int.Parse(petn)) < min) & (min == 0))
            {
                Console.Write("Некорректное значение, введите целое положительное число или 0: ");
                petn = Console.ReadLine();
            }
            else if (((num = int.Parse(petn)) < min) & (min > 0))
            {
                Console.Write("Некорректное значение, введите целое положительное число: ");
                petn = Console.ReadLine();
            }
            else
            {
                num = int.Parse(petn);
                is_int = true;
            }
        }
        while (!is_int); 
        return num;
    }
}