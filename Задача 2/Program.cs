using System;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {   //Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
            //Определить сумму максимального и минимального элементов массива.
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];

            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
            }
            Console.WriteLine("Максимальное значение в диапозоне = {0}", max);
            int min = array[0];
            foreach (int a in array)
            {
                if (a < min)
                {
                    min = a;
                }
            }
            Console.WriteLine("Минимальное значение в диапозоне = {0}", min);

        }
    }
}
