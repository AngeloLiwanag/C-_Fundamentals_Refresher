using System;

namespace Fundamentals
{
    class Program
    {
        public static global::System.Object System { get; private set; }

        static void Main(string[] args)
        {
            // for(int i = 1; i <= 255; i++)
            // {
            //     System.Console.WriteLine(i);
            // }

            for (int i = 1; i <=100; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            // for (int i = 1; i <=100; i++)
            // {
            //     if (i % 3 == 0 && i % 5 == 0)
            //     {
            //         System.Console.WriteLine("FizzBuzz");
            //     } else if(i % 3 == 0)
            //     {
            //         System.Console.WriteLine("Fizz");
            //     } else if (i % 5 == 0) 
            //     {
            //         System.Console.WriteLine("Buzz");
            //     } 
            // }
            
        }

    }

}
