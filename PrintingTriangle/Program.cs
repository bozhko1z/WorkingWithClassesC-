﻿namespace PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 1;
            var n = int.Parse(Console.ReadLine());
            PrintLine(start, end);
            PrintTriangle(n);
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i:D2}" + " ");
            }
            Console.WriteLine();


        }
        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
                PrintLine(1, line);

            for (int line = n - 1; line >= 1; line--)
                PrintLine(1, line);

        }

    }
}