using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class Check_in
    {        
        public void Greeting()
        {
            Console.WriteLine("Добро пожаловать на регистрацию");
        }

        public bool AvailableBaggage()
        {
            Console.WriteLine("Имеется ли у вас багаж?(Да/Нет)");
            string answer = Console.ReadLine();            

            if (Equals(answer.ToUpper(), "ДА"))
            {   
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public int WeightBaggage(bool availableBaggage)
        {   if (availableBaggage == true)
            { Random rnd = new Random();
                int weight = rnd.Next(10, 500);
                if (weight <= 100)
                {
                    Console.WriteLine("С вашим багажом всё в порядке.");
                    return weight;
                }
                else                     
                {
                    Console.WriteLine($"Вес вашего багажа составляет {weight}кг и превышает лимит, вам нужно доплатить."); ;
                    return weight;
                }
            }
            else
            {
                Console.WriteLine("У вас нету багажа.");
                return 0;
            }
        }

        public bool PassBoarding(bool passport)
        {
            Console.WriteLine("Держите свой посадочный талон.");
            return true;
        }
        public bool PassBoarding(bool passport, bool airTicket)
        {
            Console.WriteLine("Держите свой свой посадочный талон. ");
            return true;
        }
    }
}
