using System;
using System.Linq;
using System.Collections.Generic;


namespace hm_07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string originalText = "to, one, two! three? four five six";
            // Текст подлинее для проверки.
            //string originalText2 = "Driving up to the house, you notice the green hedge. Going through the gate, you can see the path, flowerbeds and bright lawns. At the entrance you can see the veranda where we often gather with friends to have a rest and chat.";

            Console.WriteLine("Задание 1: " + Task1(originalText));
            Console.WriteLine("Задание 2: " + Task2(originalText));
            Console.WriteLine("Задание 3: " + Task3(originalText));
            Console.WriteLine("Задание 4: " + Task4(originalText));

        }

        static string Task1 (string txt1)
        {
            txt1 = txt1.Trim();
            string[] array = txt1.Split(new char[] { ' ', ',', '.', '!', '?' });
            int maxLength = 0;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > maxLength)
                {
                    maxLength = array[i].Length;
                    maxIndex = i;
                }
            }

            txt1 = txt1.Replace(array[maxIndex], null);
           
            return txt1;
        }

        static string Task2 (string txt2)
        {
            txt2 = txt2.Trim();
            string[] array = txt2.Split(new char[] { ' ', ',', '.', '!', '?' });
            int maxLength = 0;
            int minLength = int.MaxValue;
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > maxLength)
                {
                    maxLength = array[i].Length;
                    maxIndex = i;
                }
            }

            string wordMax = array[maxIndex];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < minLength)
                {
                    minLength = array[i].Length;
                    minIndex = i;
                }
            }

            string wordMin = array[minIndex];

            array[minIndex] = wordMax;
            array[maxIndex] = wordMin;

            txt2 = string.Join(' ', array);

            return txt2;
        }

        static string Task3 (string txt3)
        {
            int numberLetters = txt3.Count(char.IsLetter);
            int numberPunctuation = txt3.Count(char.IsPunctuation);
            txt3 = String.Format("Количесвто букв = {0} \nКоличество пунктуационных знаков = {1}", numberLetters, numberPunctuation); 
            return txt3;
        }

        static string Task4 (string txt4)
        {
            txt4 = txt4.Trim();
            string[] array = txt4.Split(new char[] { ' ', ',', '.', '!', '?' });

            var sorted = from index in array
                         orderby index.Length descending
                         select index;           

           return txt4 = string.Join(' ', sorted);
        }
    }
}
