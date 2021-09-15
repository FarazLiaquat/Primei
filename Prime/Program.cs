using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            for (int x = 1; x <= 1000; x++)
            {
                z = 0;
                for (int y = 1; y <= x; y++)
                { 
                    if (x % y == 0)
                    {
                        z++;
                         
                        
                    }
                }

                if (z == 2)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}

