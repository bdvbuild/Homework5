using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание массива. Вычисление среднего арифметического.
            Console.WriteLine("Введите числа");
            int[] array = new int[7];
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            { 
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            double k = (double)sum / array.Length;
            Console.WriteLine($"Среднее арифметическое = {k}");
            Console.ReadLine();
        }
    }
}
