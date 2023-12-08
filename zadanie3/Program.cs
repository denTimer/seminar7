// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.



        int[] array = { 18, 23, 39, 42, 15, 26 };
        System.Console.WriteLine("Исходный массив");
        foreach (var element in array)
        {
        Console.Write(element + " ");
        }
        System.Console.WriteLine("");
        System.Console.WriteLine("Развернутый массив");
        PrintArrayReversed(array, array.Length - 1);
    

    void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReversed(arr, index - 1);
        }
    }

