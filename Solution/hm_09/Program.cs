using System;

namespace hm_09
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в аэропорт \"Взлётный\". \nПредставтесь пожалуйста: ");           
            Passenger passenger = new Passenger();
            passenger.Name = Console.ReadLine();

            Console.WriteLine(passenger.Name + " какой у вас номер рейса?");           
            passenger.FlightNumber = Console.ReadLine();
            
            Random rnd = new Random();
            int _numberDesk = rnd.Next(1, 20);            
            Console.WriteLine($"{passenger.Name} регистрация на ваш рейс проходит на стойке №{_numberDesk}.");

            Check_in check_In = new Check_in();

            check_In.Greeting();
            
            passenger.AvailableBaggage = check_In.AvailableBaggage();
            passenger.WeightBaggage = check_In.WeightBaggage(passenger.AvailableBaggage);

            Console.WriteLine("Вы проходили электронную регистрацию?(Да/Нет)");
            string answer = Console.ReadLine();
            if (Equals(answer.ToUpper(), "ДА"))
            {
                Console.WriteLine();
            }

        }
    }
}
