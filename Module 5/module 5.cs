using System.Xml.Linq;

internal class Program
{
    static int[] GetArrayFromConsole(int num = 5)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }
        return result;
    }
    static int[] SortMassive(int[] result)
    { 
        int tmp;
        int k = 1;
        while (k != 0)
        {
            k = 0;
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i + 1] < result[i])
                {
                    tmp = result[i];
                    result[i] = result[i + 1];
                    result[i + 1] = tmp;
                    k++;
                }
            }
        }
        return result;
    }
    static void ShowMassive(int[] result, bool isShow = false)
    {
        if (isShow)
        {
            result = SortMassive(result);
            Console.WriteLine("Числа массива в порядке возрастания");
        }
        else
        {
            Console.WriteLine("Числа массива в порядке ввода");
        }
        foreach (var item in result) Console.WriteLine(item);
     }
    private static void Main(string[] args)
    {
        Console.Write("Размерность массива? - ");
        var sortresult = GetArrayFromConsole(int.Parse(Console.ReadLine()));
        Console.Write("Массив сортировать? y/n - ");
        char yn = Console.ReadKey().KeyChar;
        Console.WriteLine();
        switch (yn)
        {
            case 'y':
                ShowMassive(sortresult, true); 
                break;
            default:
                ShowMassive(sortresult);
                break;
        }
    }
}