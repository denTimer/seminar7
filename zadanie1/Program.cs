// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


        Console.WriteLine("Введите M:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите N:");
        int n = Convert.ToInt32(Console.ReadLine());

            PrintNumbersInRange(m, n);
    

    void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + "  ");
            PrintNumbersInRange(m + 1, n);
        }
    }

