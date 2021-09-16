using System;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            int k = 0;
            for (int x = 1; x <= 100000; x++)
            {
                z = 0;
                for (int y = 1; y <= x; y++)
                { 
                    if (x % y == 0)
                    {
                        z++;
                       
                    }
                }

                if (z == 2 && k < 1000)
                {
                    Console.WriteLine(x);
                    k++;
                }
                else
                {
                }
            }
        }
    }
}

