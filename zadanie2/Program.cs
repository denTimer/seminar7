// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.




    {
        Console.WriteLine("Введите число M:");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число N:");
        int N = Convert.ToInt32(Console.ReadLine());

        int result = AckermannFunction(M, N);
        Console.WriteLine("Результат функции Аккермана для M и N: " + result);
    }

    static int AckermannFunction(int M, int N)
    {
        if (M == 0)
        {
            return N + 1;
        }
        else if (N == 0)
        {
            return AckermannFunction(M - 1, 1);
        }
        else
        {
            return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
        }
    }



