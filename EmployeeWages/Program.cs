using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            int Full_Time = 2;
            int Emp_rate = 20;
            int Emp_Hour, Emp_Wages;
            Random r = new Random();
            int check = r.Next(1, 3);
            if (check == Full_Time)
            {
                Emp_Hour = 8;
            }
            else
                Emp_Hour = 0;

            Emp_Wages = Emp_Hour * Emp_rate;
            Console.WriteLine("Employee Wages: " + Emp_Wages);
        }
    }
}
