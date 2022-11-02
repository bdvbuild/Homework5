using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упорядочить первые 5 по возрастанию, вторые 5 по убыванию.
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    int t = array[i];
                    if (array[i] > array[j])
                    {
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int i = 5; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    int t = array[i];
                    if (array[i] < array[j])
                    {
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();

        }
    }
}
