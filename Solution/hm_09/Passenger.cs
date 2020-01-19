using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class Passenger
    {   
        public const bool passport = true;        
        
        string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        bool _airTicket;
        public bool AirTicket
        {
            get
            {
                return _airTicket;
            }

            set
            {
                _airTicket = value;
            }
        }

        string _flightNumber;
        public string FlightNumber
        {
            get
            {
                return _flightNumber;
            }

            set
            {
                _flightNumber = value;
            }
        }

        bool _availableBaggage;
        public bool AvailableBaggage
        {
            get
            {
                return _availableBaggage;
            }

            set
            {
                _availableBaggage = value;
            }
        }

        int _weightBaggage;
        public int WeightBaggage
        {
            get
            {
                return _weightBaggage;
            }

            set
            {
                _weightBaggage = value;
            }
        }

        bool _passBoarding;
        public bool PassBoarding
        {
            get
            {
                return _passBoarding;
            }

            set
            {
                _passBoarding = value;
            }
        }

        bool _electronicRegistration;
        
        public bool ElectronicRegistration
        {
            get
            {
                return _electronicRegistration;
            }

            set
            {
                _electronicRegistration = value;
            }

        }
        
        private bool _handBuggage;
        public bool HandBuggage
        {
            get
            {
                return _handBuggage;
            }

            set
            {
                _handBuggage = value;
            }

        }

        public bool _forbiddenThings;
        public bool ForbiddenThings
        {
            get
            {
                return _forbiddenThings;
            }

            set
            {
                _forbiddenThings = value;
            }

        }

        public void InfoPassenger()
        {
           Console.WriteLine($"Имя пассажира - {_name}.");
           Console.WriteLine($"Номер рейса - {_flightNumber}.");
           if(_airTicket == true)
            {
                Console.WriteLine("Наличие билета: есть.");
            }
           if(_availableBaggage == true)
            {
                Console.WriteLine("Наличие багажа: есть.");
            }
            Console.WriteLine($"Вес багажа: {_weightBaggage}кг.");
            if(_passBoarding == true)
            {
                Console.WriteLine("Наличие посадочного талона: есть.");
            }

        }
    }
}
