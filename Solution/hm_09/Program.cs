using System;

namespace hm_09
{
    class Program
    { 
        static void Main(string[] args)
        {                       
            Passenger passenger = new Passenger();

            PreliminaryActions preliminaryActions = new PreliminaryActions();
            preliminaryActions.Passenger = passenger;

            Check_in check_In = new Check_in();
            check_In.Passenger = passenger;

            SecurityCheck securityCheck = new SecurityCheck();
            securityCheck.Passenger = passenger;

            PassportControl passportControl = new PassportControl();
            passportControl.Passenger = passenger;
            
            preliminaryActions.Greeting();
            preliminaryActions.FlightNumber();
            preliminaryActions.NumberDesk();
            passenger.AirTicket = preliminaryActions.AvailableTicket();
            passenger.ElectronicRegistration = preliminaryActions.ElectronicRegistration();                      
           
            
            check_In.Greeting();
            
            passenger.AvailableBaggage = check_In.AvailableBaggage();
            passenger.WeightBaggage = check_In.WeightBaggage(passenger.AvailableBaggage);
            
            
            if (passenger.ElectronicRegistration == true && passenger.AirTicket == true)
            {
                check_In.PassBoarding(Passenger.passport);
            }
            else
            {
                check_In.PassBoarding(Passenger.passport, passenger.AirTicket);
            }

            securityCheck.HandBuggage();
            securityCheck.ForbiddenThings();

            passportControl.Greeting();
            passportControl.PersonalityCheck(Passenger.passport, passportControl.Visa(), passenger.Name);

            passenger.InfoPassenger();          
        }
    }
}
