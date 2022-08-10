using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int part_time = 1;
            int full_time = 2;
            int empHour = 0;
            int empWage = 0;

            int empRateperHour = 8;

            int empcheck;

            Random random = new Random();
            empcheck = random.Next(0, 3);

            if (empcheck == 0)
            {
                Console.WriteLine("Employe is absent");
                empHour = 0;
            }
            
            
            else
                    {
                Console.WriteLine("Employee is working full time ");
                empHour = 5;
            }
            empWage = empHour * empRateperHour;
            Console.WriteLine("the employee wage is " + empWage);
        }
    }
}
