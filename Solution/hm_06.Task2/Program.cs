using System;

namespace hm_06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            String nul = "Вы ввели не число, попробуйте ещё раз.";

            Console.WriteLine("Введите 4 значения для заполения массива:");
            bool checkNull;
            for (int i = 0; i < array.Length-1; i++)
            {
                checkNull = int.TryParse(Console.ReadLine(), out array[i]);   
                if (checkNull == false)
                {
                    Console.WriteLine(nul);
                    i--;
                }
            }            

            Console.WriteLine("Введите значение для последнего элемента:");
            int lastValue = 0;
            bool checkNull2;
            do 
            {
                checkNull2 = int.TryParse(Console.ReadLine(), out lastValue);
                if (checkNull2 == false)
                {
                    Console.WriteLine(nul);
                }
            }
            while (checkNull2 == false);    

            int position = 0;
            do
            {   if (position > array.Length)
                {
                    Console.WriteLine("Неверный номер позиции, повторите ещё раз.");
                }
                else
                {
                    Console.WriteLine("Введите номер позиции:");
                }
                int.TryParse(Console.ReadLine(), out position);                
            }  
            while (position > array.Length); ;

            for ( int i = array.Length-1; i > 0; i--)
            {   
                if(i >= position)
                {
                    array[i] = array[i - 1];
                }      
            }

            array[position-1] = lastValue;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
           
        }
    }
}
