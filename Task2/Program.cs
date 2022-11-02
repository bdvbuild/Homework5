using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Определение максимального и минимального числа в рандомном массиве
            int[] array = new int[15];
            Random random = new Random();
            int min = 0;
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,50);
                min = (min > array[i]) ? min = array[i] : min;
                max = (max < array[i]) ? max = array[i] : max;
            }
            Console.WriteLine($"Минимальное = {min}. Максимальное = {max}");
            Console.ReadLine();
        }
    }
}
