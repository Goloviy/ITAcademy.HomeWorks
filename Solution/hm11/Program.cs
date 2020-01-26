using System;

namespace hm11
{
    class Program
    {
        static void Main(string[] args)
        {         
            static Figure GreateFigure (int index)
            {
                int i = index;
                Random rnd = new Random();

                if (i == 0)
                {
                    Circle circle = new Circle("Circle", rnd.Next(1,10));
                    return circle;
                }
                else if (i == 1)
                {
                    Square square = new Square("Square", rnd.Next(1, 10));
                    return square;
                }
                else if (i == 2)
                {
                    Triangle triangle = new Triangle("Triangle", rnd.Next(1, 10));
                    return triangle;
                }
                else return null;
            }        

            Figure[] figures = new Figure[3];

            for (int i = 0; i < figures.Length; i++)
            {
                figures[i] = GreateFigure(i);
                Console.WriteLine($"This is {figures[i].NameFigure}. CLR Type is {figures[i].ToString()}." +
                    $" Square is {figures[i].AreaFugure()}");
            }            
        }
    }
}
