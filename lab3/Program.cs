using System;
using System.Collections.Generic;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> I = new List<float>();
            List<float> U = new List<float>();
            float R, sum1 = 0, sum2 = 0;

            Console.Write("Введіть кількість замірів напруги і сили струму: ");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Сила струму {i + 1} = ");
                I.Add(float.Parse(Console.ReadLine()));
                Console.Write($"Напруга {i + 1} = ");
                U.Add(float.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            for (int i = 0; i < count; i++)
            {
                sum1 += I[i] * U[i];
                sum2 += I[i] * I[i];
            }

            R = sum1 / sum2;
            Console.WriteLine($"Приближене значення опору = {R}");
        }
    }
}
