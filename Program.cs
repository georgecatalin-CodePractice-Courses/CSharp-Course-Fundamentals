using System;

namespace src
{

    // Issue of The type or namespace name 'System' could not be found>> Solution: vanishes if I target netcoreapp2.2.
    class Program
    {
        static void Main(string[] args)
        {
            double x=34.1;
            double y=10.3;

            double result=x+y;

            System.Console.WriteLine(result);

            if (args.Length>0)
            {
                 Console.WriteLine($"Hello {args[0]}!"); 
            }
            else{
                Console.WriteLine("Help needed");
            }
          
        }
    }
}
