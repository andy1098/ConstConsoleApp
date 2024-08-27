internal class Arrays
{
    private static void Main(string[] args)
    {
        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

        // сортировка 1-мерного массива
        int tmp;
        int k = 1;
        while (k != 0)
        {
            k = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] < arr[i])
                {
                    tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                    k++;
                }
            }
        }
        // Подсчет суммы и вывод на экран 1-мерного массива
        k = 0;
        foreach (var j in arr)
        {
            k += j;
            Console.Write("{0} ", j);
            Console.WriteLine();
        }
        Console.WriteLine("Сумма чисел массива {0}", k);

        // Зубчатый массив
        int[][] array = new int[3][];
        array[0] = new int[2] { 1, 2 };
        array[1] = new int[3] { 1, 2, 3 };
        array[2] = new int[5] { 1, 2, 3, 4, 5 };
        foreach (var x in array)
        {
            foreach (var y in x)
            {
                Console.Write(y + " ");
            }
            Console.WriteLine();
        }

        int[,] arr1 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

        // подсчет кол-ва положительных чисел 
        k = 0;
        foreach (var j in arr1)
        {
            if (j > 0)
            {
                k++;
            }
        }
        Console.WriteLine("В массиве положительных чисел - {0}", k);

        // сортировка 2-х мерного массива
        for (int i = 0; i <= arr1.GetUpperBound(0); i++)
        {
            k = 1;
            while (k != 0)
            {
                k = 0;
                for (int j = 0; j <= arr1.GetUpperBound(1) - 1; j++)
                {
                    if (arr1[i, j + 1] < arr1[i, j])
                    {
                        tmp = arr1[i, j];
                        arr1[i, j] = arr1[i, j + 1];
                        arr1[i, j + 1] = tmp;
                        k++;
                    }
                }
            }
                
        }
        // Вывод 2-х мерного массива на экран построчно
        for (int i = 0; i < arr1.GetUpperBound(0) + 1; i++)
        {
            for (int j = 0; j < arr1.GetUpperBound(1) + 1; j++)
                Console.Write(arr1[i, j] + " ");
            Console.WriteLine();
        }

            //Console.WriteLine(array.Length);
            // Console.WriteLine(array.GetUpperBound(0));
            // Console.Write("Введите свое имя: ");
            //         var word = Console.ReadLine();
            //        Console.WriteLine("Ваше имя в обратном порядке");
            //        int i = word.Length - 1;
            //        while (i > -1)
            //        {
            //            Console.Write("{0} ", word[i]);
            //            i--;
            //        }
            //        Console.ReadKey();

            // Console.WriteLine("Последняя буква Вашего имени - {0}", word[^1]);
        }
}