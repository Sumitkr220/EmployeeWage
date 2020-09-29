using System;

namespace EmployeeWages
{
    class Program
    {
        public const int FULL_TIME = 2;
        public const int PART_TIME = 1;
        public static int ComputeEmpWage(string company,int empRate,int totalOfWorkingDays,int maxHoursPerMonth)
        {
            int noOfWorkingDays = 0;
            int empHour=0;
            int totalEmpWages = 0;
            int workingHour = 0;
            Random r = new Random();
            while (noOfWorkingDays < totalOfWorkingDays && workingHour < maxHoursPerMonth)
            {
                noOfWorkingDays++;
                int check = r.Next(1, 4);
                switch (check)
                {
                    case 2:
                        empHour = 8;
                        break;
                    case 1:
                        empHour = 4;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                workingHour += empHour;
                Console.WriteLine("Days#:" + noOfWorkingDays + " Emp Hrs :" + empHour);
            }
            totalEmpWages = workingHour * empRate;
            Console.WriteLine("Total Employee Wage for company : "+company+" is " + totalEmpWages);
            return totalEmpWages;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("DMart",20,20,100);
            ComputeEmpWage("Reliance", 10, 18, 200);
        }
    }
}
