using System;

namespace hm_07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение разделяя строки точкой с запятой: ");
            string txt = Console.ReadLine();
            string[] array = txt.Split(';');           
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].Replace("O", "A");
                Console.WriteLine(array[i]);
            }   
        }
    }
}
