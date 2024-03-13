﻿class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение M: ");
        int m = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        PrintNaturalNumbers(m, n);


    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbers(m + 1, n);
        }
    }
  }
}