using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class Passenger
    {   
        const bool passport = true;        
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

    }
}
