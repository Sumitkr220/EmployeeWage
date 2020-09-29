using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class EmpWageBuilderObject
    {
        public const int FULL_TIME = 2;
        public const int PART_TIME = 1;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            Random random = new Random();
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
            {
                totalWorkingDays++;
                int check = random.Next(1, 4);
                switch (check)
                {
                    case 2:
                        empHrs = 8;
                        break;
                    case 1:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + " Emp Hrs :" + empHrs);
            }
            totalEmpWage = totalEmpHrs *this.empRatePerHour;
            Console.WriteLine("Total Employee Wage for company : " + company + " is " + totalEmpWage);     
        }

        public string toString()
        {
            return "Total Emp Wage for company : " + this.company + " is: " + this.totalEmpWage;
        }
    }
}