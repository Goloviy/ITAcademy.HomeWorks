using System;

namespace HW03.Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 16;
            object newObject1 = num1;

            char newChar1 = 'W';
            object newObject2 = newChar1;

            bool newBool1 = true;
            object newObject3 = newBool1;


            int num2 = (int)newObject1;
            char newChar2 = (char)newObject2;
            bool newBool2 = (bool)newObject3;


        }
    }
}
