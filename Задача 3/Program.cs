﻿using System;

namespace Задача_3
{
    class Program
    {
        //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].
        //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write(" {0} ", array[i]);
            }
            Console.WriteLine(" -Исходный массив");
            //Сортировка первых 5-и элементов
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            //Сортировка вторых 5-и элементов
            for (int i = 5; i > 5; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(" {0} ", array[i]);
            }
            Console.WriteLine(" -Сортированный массив ");
        }
    }
}
