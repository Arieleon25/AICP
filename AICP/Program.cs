using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            int hourlyRate1 = 15;
            int hourlyRate2 = 20;
            int HoursPerWeek = 40;
            int yrSalary1 = 31200;
            int yrSalary2 = 41600;
            int person1 = yrSalary1;
            int person2 = yrSalary2;
            bool Ps1vsPs2 = person1 > person2;

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: " + hourlyRate1);
            Console.WriteLine("Hours worked per week: " + HoursPerWeek);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: " + hourlyRate2);
            Console.WriteLine("Hours worked per week: " + HoursPerWeek);

            Console.WriteLine("Annual salary of person 1: " + yrSalary1);
            Console.WriteLine("Annual salary of person 2: " + yrSalary2);

            Console.WriteLine("Does Person 1 make more money than person 2? " + Ps1vsPs2);

            Console.ReadLine();
        }
    }
}
