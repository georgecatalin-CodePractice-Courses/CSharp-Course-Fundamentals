using System;
using System.Collections.Generic;

namespace GradeBook
{

    // Issue of The type or namespace name 'System' could not be found>> Solution: vanishes if I target netcoreapp2.2.
    class Program
    {
        static void Main(string[] args)
        {
           Book book=new Book("George"); 
           book.AddGrade(89.1);
           book.AddGrade(90.5);
           book.AddGrade(77.1);
           book.ShowStatistics();
        }
    }
}
