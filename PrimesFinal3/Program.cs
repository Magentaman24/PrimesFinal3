using System;

namespace PrimesFinal3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0; 
            for (int i = 0; i < 8000; i++)
            {
                int counter = 0;

                for (x = i; x >= 1; x--)
                {
                    if (i % x == 0)
                    {
                        counter++; 
                    }
                }

                if (counter == 2)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
