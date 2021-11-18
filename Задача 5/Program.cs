using System;

namespace Задача_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя целочисленное значение N.
            //Сформировать двумерный массив размера NxN следующего вида:

            Console.WriteLine("Введите целочисленное значение N");
            int N = Convert.ToInt32(Console.ReadLine());
            int m = N;
            int n = N;
            int a = 0;
            int[,] t = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a==0)
                    {
                        t[i, j] = 1;
                        a = 1;
                    }
                    else if(a==1)
                    {
                        t[i, j] = 0;
                        a = 0;
                    }
                    Console.Write("{0,2} ", t[i, j]);
                }
                Console.WriteLine();
            }

        }

    }
}

