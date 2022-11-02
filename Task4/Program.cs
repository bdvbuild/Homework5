using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Определить количество нечетных положительных элементов, стоящих на четных местах.
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 1; i < array.Length; i+=2)
            {
                if ((array[i] > 0) && (array[i]%2!=0))
                {
                ++count;
                }
            }
            Console.Write($"Количество нечетных положительных элементов, стоящих на четных местах = {count}.");
            Console.ReadLine();


        }
    }
}
