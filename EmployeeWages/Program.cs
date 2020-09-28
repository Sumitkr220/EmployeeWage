using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int Full_Time = 2;
            int Part_Time = 1;
            int Emp_rate = 20;
            int Emp_Hour, Emp_Wages;
            Random r = new Random();
            int check = r.Next(1, 4);

            switch (check)
            {
                case 2:
                    Emp_Hour = 8;
                    break;
                case 1:
                    Emp_Hour = 4;
                    break;
                default:
                    Emp_Hour = 0;
                    break;
            }

            Emp_Wages = Emp_Hour * Emp_rate;
            Console.WriteLine("Employee Wages: " + Emp_Wages);
        }
    }
}
