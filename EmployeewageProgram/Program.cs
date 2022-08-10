using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_employee_wage
{
    internal class Program
    {

        public const int emp_rate_per_hour = 20;
        public const int part_time = 1;
        public const int full_time = 2;
        public const int totalWorkingdays = 20;
        static void Main(string[] args)
        {

            int emp_hour = 0;
            int emp_wage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 3);


            switch (empcheck)
            {
                case part_time:

                    emp_hour = 4;
                    break;

                case full_time:
                    emp_hour = 8;
                    break;

                default:
                    emp_hour = 0;
                    break;
            }

            emp_wage = emp_hour * emp_rate_per_hour;
            int emp_total_wage;
            emp_total_wage = emp_wage * totalWorkingdays;

            Console.WriteLine("employee wage is : " + emp_wage);
        }
    }
}