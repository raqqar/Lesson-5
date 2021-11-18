using System;

namespace Задача_4
{
    class Program
    {
        //Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
        //Определить количество   нечетных положительных элементов, стоящих на четных местах.
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            int a = 0;
            Random random = new Random();
            int C = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write(" {0} ", i);
                Console.WriteLine(" {0} ", array[i]);
                if (i != 0 && i % 2 == 0)
                {
                    if (array[i] > 0 && array[i] % 2 != 0)
                    {
                        C++;
                    }
                }
            }
            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах = {0}",C);
        }
    }
}
