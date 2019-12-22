using System;
using System.Collections.Generic;

namespace hm_06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = 10;    
            
            int[] array = new int [arrayLength];
            Console.WriteLine("Введите 10 значений для заполнения массива.");            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());                   
            }
            Console.Write("Массив заполненный с клавиатуры:\t\t");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            } 
            
            int[] array2 = new int[arrayLength];
            Random rnd = new Random();
            Console.Write("\nМассив заполненый случайными числами от 0 до 9: ");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(10);
                Console.Write(array2[i] + " ");
            }

            int[] array3 = new int[arrayLength];
            Console.Write("\nСуммарный массив:\t\t\t\t");
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array[i] + array2[i];
                Console.Write(array3[i] + " ");
            }

        }
    }
}
