// 
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 2; // Измените значение m здесь
        int n = 3; // Измените значение n здесь

        int result = AckermannFunction(m, n);
        Console.WriteLine("A({0},{1}) = {2}", m, n, result);

        Console.ReadLine();
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}