using System;

namespace hm_04_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            string input;
            do
            {
                do
                {   Console.WriteLine("Введите желаемое действие:\n1. W - вверх\n2. S - вниз\n3. A - влево\n4. W - вправо\n5. Пробел - остатьс на месте");
                    input = Console.ReadLine();
                    if (input.Length != 1)
                    {
                        Console.WriteLine("Некорекктное количество символов.\nПопробуйте ещё раз.");
                    }
                } while (input.Length != 1);
                char input2 = Convert.ToChar(input);
                input2 = char.ToLower(input2);
                switch (input2)
                {
                    case 'w':
                        Console.WriteLine("Фигура сдвинулась вверх.");
                        break;
                    case 's':
                        Console.WriteLine("Фигура сдвинулась вниз.");
                        break;
                    case 'a':
                        Console.WriteLine("Фигура сдвинулась вправо.");
                        break;
                    case 'd':
                        Console.WriteLine("Фигура сдвинулась влево.");
                        break;
                    case ' ':
                        Console.WriteLine("Фигура осталась на месте.");
                        break;

                }                
                Console.WriteLine("Желаете продолжить:\t" + "da\t" + "net");
                answer = (Console.ReadLine());
            } while (answer == "da");
            
            Console.ReadKey();
        }
    }
}
