using System;

namespace hm_10.Task02
{
    class Program
    {
        static void Main(string[] args)
        {   //Link - https://www.codewars.com/kata/55a144eff5124e546400005a
            //Your task is to complete this Class, the Person class has been created.
            //You must fill in the Constructor method to accept a name as string and an age as number, 
            //complete the get Info property and getInfo method/Info getter which should return
        }
        public class Person
        {
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public string Name { get; set; }
            public int Age { get; set; }

            public string Info
            {
                get { return $"{this.Name}s age is {this.Age}"; }

            }
        }
    }
}
