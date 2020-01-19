using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class PreliminaryActions
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
            Console.WriteLine("Добро пожаловать в аэропорт \"Взлётный\". \nПредставтесь пожалуйста: ");
            Passenger.Name = Console.ReadLine();
        }

        public void FlightNumber()
        {
            Console.WriteLine(Passenger.Name + " какой у вас номер рейса?");
            Passenger.FlightNumber = Console.ReadLine();
        }

        public void NumberDesk()
        {
            Random rnd = new Random();
            int _numberDesk = rnd.Next(1, 20);
            Console.WriteLine($"{Passenger.Name} регистрация на ваш рейс проходит на стойке №{_numberDesk}.");
        }

        public bool AvailableTicket()
        {
            Console.WriteLine("У вас билет бумажный билет или электронный?" +
                "\n1 - Бумажный билет.\n2 - Электронный билет.");

            int _typeTicket;
            int.TryParse(Console.ReadLine(), out _typeTicket);

            if (_typeTicket == 1)
            {
                return Passenger.AirTicket = true;
            }
            else
            {
                Console.WriteLine("Желаете распечатать его сейчас?(Да/Нет)");
                string answer;
                do
                {
                    answer = Console.ReadLine();
                } while (answer.Equals("Да") && answer.Equals("Нет"));

                if (answer == "Да")
                {
                    Console.WriteLine("Пройдите к термилу и распечайте его там.");
                    return Passenger.AirTicket = true;
                }
                else
                {
                    Console.WriteLine("Его можно будет распечатать на стойке регистрации.");
                    return Passenger.AirTicket = false;
                }
            }           
        }

        public bool ElectronicRegistration()
        {
            Console.WriteLine("Вы проходили электронную регистрацию?(Да/Нет)");
            string answer = Console.ReadLine();
            if (Equals(answer.ToUpper(), "ДА"))
            {
                return Passenger.ElectronicRegistration = true;
            }
            else
            {
               return Passenger.ElectronicRegistration = false;
            }
        }
    }
}
