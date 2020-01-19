using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class SecurityCheck
    {
        private Passenger _passenger;
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

        public bool HandBuggage ()
        {
            Console.WriteLine("Положите ручную кладь на ленту." +
                "\nНажмите на кнопку, что-бы положить ручную кладь.");
            Console.ReadKey();
            Console.WriteLine("Ваша ручная кладь впорядке.");
            return Passenger.HandBuggage = true;
        }

        public bool ForbiddenThings()
        {
            Console.WriteLine("А теперь проверим вас на наличие запрещённых вещей." +
                "\nНажмите кнопку что-бы пройти осмотр.");
            Console.ReadKey();
            Console.WriteLine("У вас нет запрещённых вещей, прохоидте на паспортный контроль.");
            return Passenger.ForbiddenThings = false;
        }


    }
}
