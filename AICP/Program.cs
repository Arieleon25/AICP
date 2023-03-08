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

            int hourlyRate1 = 0;
            int hourlyRate2 = 0;
            int HoursPerWeek1 = 0;
            int HoursPerWeek2 = 0;

            Console.WriteLine("Person 1");
            Console.WriteLine("P1 Hourly Rate?");
            hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("P1 Hourly Rate is: " + hourlyRate1);
            Console.WriteLine("P1 Hours worked per week?");
            HoursPerWeek1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("P1 Hours worked per week: " + HoursPerWeek1);
            int yrSalary1 = hourlyRate1 * HoursPerWeek1 * 52;

            Console.WriteLine("Person 2");
            Console.WriteLine("P2 Hourly Rate?");
            hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("P2 Hourly Rate: " + hourlyRate2);
            Console.WriteLine("P2 Hours worked per week?");
            HoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("P2 Hours worked per week: " + HoursPerWeek2);
            int yrSalary2 = hourlyRate2 * HoursPerWeek2 * 52;
            ;
            Console.WriteLine("Annual salary of person 1: " + yrSalary1);
            Console.WriteLine("Annual salary of person 2: " + yrSalary2);

            bool Ps1vsPs2 = yrSalary1 > yrSalary2;
            Console.WriteLine("Does Person 1 make more money than person 2? " + Ps1vsPs2);

            Console.ReadLine();
        }
    }
}
