using System;

namespace hm_10.Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            //link https://www.codewars.com/kata/563089b9b7be03472d00002b
            //Define a method/function that removes from a given array of integers all 
            //the values contained in a second array.
        }
        public class Kata
        {
            public static int[] Remove(int[] integerList, int[] valuesList)
            {
                int a = integerList.Length;
                for (int i = 0; i < integerList.Length; i++)
                {
                    for (int j = 0; j < valuesList.Length; j++)
                    {
                        if (integerList[i].Equals(valuesList[j]))
                        {
                            a--;
                            integerList[i] = 0;
                        }
                    }
                }

                int[] result = new int[a];
                int index = 0;
                for (int i = 0; i < integerList.Length; i++)
                {
                    if (integerList[i] != 0)
                    {
                        result[index] = integerList[i];
                        index++;
                    }
                }
                return result;
            }
        }
    }
}
