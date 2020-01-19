using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class PassportControl
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
            Console.WriteLine("Добро пожаловать на паспортый контроль, ваш паспорт пожалуйста.");
        }
        public bool Visa()
        {
            return Passenger.Visa = true;
        }

        public bool PersonalityCheck(bool passport, bool visa, string name)
        {
            passport = Passenger.passport;
            visa = Visa();
            name = Passenger.Name;
            Console.WriteLine("Скажите ваше имя и фамилию для проверки.");
            string checkName;
            checkName = Console.ReadLine();
            if (passport == true && visa == true && checkName.Equals(name))
            {
                Console.WriteLine("\nВсё верно проходите на самолет.\n");
                return Passenger.PersonalityCheck = true;
            }
            else
            {
                Console.WriteLine("Возника проблема, пройдёмте с нами для её разрешения.");
                return Passenger.PersonalityCheck = false;
            }
            
        }
    }
}
