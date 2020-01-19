using System;

namespace hm_10.Task01
{
    class Program
    {
        static void Main(string[] args)
        {   //link - https://www.codewars.com/kata/55b75fcf67e558d3750000a3
            // The constructor should take an array as an argument, 
            //this will contain 3 integers of the form[width, length, height] 
            //   from which the Block should be created.
            Console.WriteLine("Hello World!");
            Block block = new Block(new int[] { 2, 4, 6 });
            Console.WriteLine(block.GetSurfaceArea());
            Console.WriteLine(block.GetVolume());
        }
        class Block
        {
            int width;
            int length;
            int height;
            public int GetWidth ()
            {
                return width;
            }

            public int GetLength()
            {
                return length;
            }

            public int GetHeight()
            {
                return height;
            }

            public int GetVolume()
            {
                return width*length*height;
            }
            public int GetSurfaceArea()
            {
                return width*height*6;
            }
            public Block(int [] array)
            {
                width = array[0];
                length = array[1];
                height = array[2];
                
            }
        }
    }
}
