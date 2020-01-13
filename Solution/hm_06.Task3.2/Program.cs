using System;
using System.Diagnostics;
namespace hm_06.Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("Старт");
            const long lengthArray = 100000000;
            long[] array = new long[lengthArray];            
            Random rnd = new Random();            

            for (long i = 0; i < lengthArray; i++)
            {
                array[i] = rnd.Next();
            }

            Array.Reverse(array);

            Console.WriteLine("Финиш");
            watch.Stop();

            Console.WriteLine("Количество миллисекунд=" + watch.ElapsedMilliseconds);
        }
    }
}
