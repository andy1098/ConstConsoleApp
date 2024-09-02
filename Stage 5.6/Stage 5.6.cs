internal class Program
{
    

    private static void Main(string[] args)
    
    {
        (string name, string surname, int age, bool has_pet, int numpet, string[] namespet, int numcolor, string[] colors) Anketa;

        string yn = "";
        do
        {
            Anketa = EnterData();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Ваше имя и фамилия: " + Anketa.name + " " + Anketa.surname);
            if (Anketa.namespet[0] != "")
            {
                var i = 1;
                foreach (string name in Anketa.namespet)
                {
                    Console.WriteLine("Имя {0}-го питомца {1}", i, name);
                    i++;
                }
            }

            Console.WriteLine("--------------------------------------");
            Console.Write("Повторим? y/n: ");
            yn = Console.ReadLine();

            int k = 1;    
            while (k == 1)
            {
                switch (yn)
                {
                    case "y":
                        k = 0;
                        break;
                    case "n":
                        k = 0;
                        break;
                    default:
                        Console.Write("Прошу ввести корректный ответ - y/n: ");
                        yn = Console.ReadLine();
                        break;
                }
            }
        }
        while (yn != "n");
        // Console.ReadKey();
    }

    
    static (string, string, int, bool, int, string[], int, string[]) EnterData()
    {
        string[] colors, petsname;

        Console.Write("Введите имя:");
        var name = Console.ReadLine();
        Console.Write("Введите фамилию:");
        var surname = Console.ReadLine();
        Console.Write("Введите возраст пользователя: ");
        var age = ToInt(Console.ReadLine());

        var petnum = 0;
        Console.Write("У Вас есть домашний питомец? ");
        bool has_pet = Console.ReadLine() == "да" ? true : false;

        // string[] colors = { "" };
        if (has_pet)
        { 
            Console.Write("Укажите количество домашних питомцев: ");
            petnum = ToInt(Console.ReadLine());
            petsname = GetArray(petnum, "Укажите имя домашнего питомца ");
        }
        else
        {
            petsname = new[] { "" };
        }

        Console.Write("Введите количество любимых цветов: ");
        var numcolors = ToInt(Console.ReadLine());
        if (numcolors != 0)
        {
            colors = GetArray(numcolors, "Введите любимый цвет #");
        }
        else
        {
            colors =  new[] { "" };
        }
        return (name, surname, age, has_pet, petnum, petsname, numcolors, colors);

       // if (petsname[0] == "")
        //{
          //  if (colors[0] == "")
           // {
           //     return (name, surname, age, has_pet, petnum, numcolors);
           // }
            //else
           // {
            //    return (name, surname, age, has_pet, petnum, numcolors, colors);
           // }
       // }
        //else
        //{
         //   return (name, surname, age, has_pet, petnum, petsname, numcolors, colors);
        //}
        
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
    static int ToInt(string petn) // Проверка целого положительного числа
    {
        int num = -1;
        do
            if (!int.TryParse(petn, out num))
            {
                Console.Write("Некорректное значение, введите целое положительное число: ");
                petn = Console.ReadLine();
            }
        while (num == -1); 
        return num;
    }
  
}