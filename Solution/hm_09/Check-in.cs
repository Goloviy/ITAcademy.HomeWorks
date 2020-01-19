using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class Check_in    
    {
        Passenger _passenger;
        public Passenger Passenger
        {
            get
            {
                return _passenger;
            }

            set
            {
                _passenger = value;
            }

        }
        public void Greeting()
        {
            Console.WriteLine("Добро пожаловать на стойку регистрации.");
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
        {
            availableBaggage = Passenger.AvailableBaggage;
            if (availableBaggage == true)
            { Random rnd = new Random();
                int weight = rnd.Next(10, 500);
                if (weight <= 100)
                {
                    Console.WriteLine("С вашим багажом всё в порядке.");
                    return weight;
                }
                else                     
                {
                    int pay;
                    Console.WriteLine($"Вес вашего багажа составляет {weight}кг и превышает лимит, вам нужно доплатить {weight/10} у.е.");
                    do
                    {
                       Console.WriteLine("Доплатите нужную сумму");                       
                       int.TryParse(Console.ReadLine(), out pay);
                        
                    } while (pay != weight/10);
                    Console.WriteLine("Платеж принят.");
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
            passport = Passenger.passport;
            if (passport == true)
            {
                Console.WriteLine("Держите свой свой билет и посадочный талон, проходите дальше.");
                return Passenger.PassBoarding = true;
            }
            else//there will always be true, made just for verification 
            {   
                Console.WriteLine("Что-то сломалось.");
                return false;
            }
        }

        public void CheckName()
        {
            Console.WriteLine("Ваше имя и фамилия.");
            string checkName;
            do
            {                  
                checkName = Console.ReadLine();
                String.Equals(checkName, Passenger.Name);
                if(checkName != Passenger.Name)
                {
                    Console.WriteLine("Вы сказали неверное имя и фамилию, повторите пожалуйста.");
                }
            } while (checkName != Passenger.Name);
        }
        public bool PassBoarding(bool passport, bool airTicket)
        {   passport = Passenger.passport;
            airTicket = Passenger.AirTicket;
            if (passport == true && airTicket == true)
            {               
                CheckName();
                Console.WriteLine("Всё впорядке, держите свой свой посадочный талон и проходите дальше.");
                return Passenger.PassBoarding = true;
            }
            else
            {
                CheckName();
                Console.WriteLine("Покажите пожалуйста QR-код на экране смартфона, мы распечатаем ваш билет." +
                    "\nНажмите любую кнопку для демонстрации экрана.");
                Console.ReadKey();
                Console.WriteLine("Держите свой билет и посадочный талон, проходите на дальше.");
                Passenger.AirTicket = true;
                return Passenger.PassBoarding = true;
            }
        
        }
    }
}
