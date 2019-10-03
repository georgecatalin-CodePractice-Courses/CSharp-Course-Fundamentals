using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Book {
      List<double> grades; //instance fields
      private string name; //instance fields


      public Book(string name){
       grades=new List<double>();
       this.name=name;
      
      }

      public void AddGrade(double grade)
      {
        grades.Add(grade);
      }

      public void ShowStatistics(){
           double result=0.0d;
           double highGrade=double.MinValue;
           double lowGrade=double.MaxValue;

           foreach (double grade in grades)
           {
               highGrade=Math.Max(grade,highGrade);
               lowGrade=Math.Min(grade,lowGrade);
               result+=grade;
           }
    
            result/=grades.Count;

            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The average grade is {result:N1}");

      }



  }
}