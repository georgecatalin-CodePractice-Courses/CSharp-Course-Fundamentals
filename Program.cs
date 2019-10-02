using System;
using System.Collections.Generic;

namespace src
{

    // Issue of The type or namespace name 'System' could not be found>> Solution: vanishes if I target netcoreapp2.2.
    class Program
    {
        static void Main(string[] args)
        {
           List<double> grades=new List<double>(){12.7,10.3,6.11,4.1};
           grades.Add(56.1);

           double result=0.0d;

           foreach (double grade in grades)
           {
               result+=grade;
           }
    
            result/=grades.Count;

            System.Console.WriteLine($"The average grade is {result:N1}");

            if (args.Length>0)
            {
                System.Console.WriteLine($"Hello, {arg[0]}");
            }
            else
            {
                System.Console.WriteLine("Help wanted");
            }
        }
    }
}
