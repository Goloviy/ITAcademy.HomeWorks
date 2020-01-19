using System;

namespace hm_10.Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            //link - https://www.codewars.com/kata/54fe05c4762e2e3047000add
            //Every time your spies see a new ship enter the dock, they will 
            //create a new ship object based on their observations:
            //draft - an estimate of the ship's weight based on how low it is in the water
            // crew - the count of crew on board

           // Taking into account that an average crew member on board adds 1.5 units to the draft, 
           //a ship that has a draft of more than 20 without crew is considered worthy to loot. 
           //Any ship weighing that much must have a lot of booty!
        }
        public class Ship
        {
            public int Draft;
            public int Crew;

            public Ship(int draft, int crew)
            {
                Draft = draft;
                Crew = crew;
            }
            public bool IsWorthIt()
            {
                return (Draft - Crew * 1.5) > 20;
            }

        }
    }
}
