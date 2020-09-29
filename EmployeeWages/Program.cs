using System;

namespace EmployeeWages
{
    class Program
    {
        public const int FULL_TIME = 2;
        public const int PART_TIME = 1;
        public const int EMP_RATE = 20;
        public const int MAX_WORKING_HOUR = 100;
        public const int MAX_WORKING_DAYS = 20;
        public static int ComputeEmpWage()
        {
            int noOfWorkingDays = 0;
            int empWages = 0;
            int workingHour = 0;
            Random r = new Random();
            while (noOfWorkingDays < MAX_WORKING_DAYS && workingHour < MAX_WORKING_HOUR)
            {
                noOfWorkingDays++;
                int check = r.Next(1, 4);
                int empHour;
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
                empWages += empHour * EMP_RATE;
            }
            Console.WriteLine("Employee Wages: " + empWages);
            return empWages;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();  
        }
    }
}
