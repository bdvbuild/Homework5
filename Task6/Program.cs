using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Запросить у пользователя целочисленное значение N. 
            Сформировать двумерный массив размера NxN.
            Заполнить массив числами, вводимыми с клавиатуры. 
            Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
            */
            Console.WriteLine("Введите размерность массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            Console.WriteLine();

            //Ввод чисел в массив
            for (int i = 0; i < n; i++)     
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите число {i + 1}:{j + 1} - ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //Вывод массива в консоль
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ",array[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Создаем массив для сумм строк, колонок и диагоналей
            int strSum = 0;
            int rowSum = 0;
            int dgnlSum1 = 0;
            int dgnlSum2 = 0;
            int[,] compareArray = new int[2, n+1];
            
            //Суммы строк
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    strSum += array[i, j];
                }
                compareArray[0, i] = strSum;
                strSum = 0;
            }

            //Суммы колонок
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    rowSum += array[i, j];
                }
                compareArray[1, j] = rowSum;
                rowSum = 0;
            }

            //Суммы диагоналей
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        dgnlSum1 += array[i, j];
                    }
                }
            }
            compareArray[0, n] = dgnlSum1;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) == (n - 1))
                    {
                        dgnlSum2 += array[i, j];
                    }
                }
            }
            compareArray[1, n] = dgnlSum2;

            //Сравниваем сумму строк, столбцов, диагоналей
            bool t = true;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (compareArray[i, j] != compareArray[i, j + 1])
                    { 
                        t = false;
                        break;
                    }
                }
            }
            if (compareArray[0, 0] != compareArray[1, 0])
            {
                t = false;
            }


            if (t == true)
                 Console.WriteLine("Массив является магическим квадратом");
            else Console.WriteLine("Массив не является магическим квадратом");

            Console.ReadKey();


        }
    }
}
