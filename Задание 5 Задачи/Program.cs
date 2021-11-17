using System;

namespace Задание_5_Задачи
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 7 элементов.
            //Заполнить массив числами, вводимыми с клавиатуры,
            //определить среднее арифметическое элементов.
            int[] array = new int[7];
            float S = 0;
            int N = 0;
            Console.WriteLine("Введите 7 чисел,для заполнения массива");
            for (int i = 0; i < 7; i++)
            {
                N = Convert.ToInt32(Console.ReadLine());
                array[i]= N;
                S += array[i];
            }
            Console.WriteLine("Среднее арефметическое = {0}",S/7);
        }
    }
}
