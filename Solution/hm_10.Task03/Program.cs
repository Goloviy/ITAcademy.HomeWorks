using System;

namespace hm_10.Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            //link - https://www.codewars.com/kata/53f0f358b9cb376eca001079
            //Create a class Ball.
            //Ball objects should accept one argument for "ball type" when instantiated.
            //If no arguments are given, ball objects should instantiate with a "ball type" of "regular."
            Ball ball = new Ball();
            Ball ball1 = new Ball("super");
            Console.WriteLine(ball.ballType);
            Console.WriteLine(ball1.ballType);

        }
        public class Ball
        {
            public string ballType { get; set; }

            public Ball()
            {
                this.ballType = "regular";
            }

            public Ball(string ballType)
            {
                if (string.Equals(ballType, "super"))
                {
                    this.ballType = "super";
                }
            }
        }
    }
}
