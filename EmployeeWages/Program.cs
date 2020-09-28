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
            int No_Of_Working_Days = 0;
            int Total_Working_Hour = 100;
            int Emp_Hour = 0, Emp_Wages = 0;
            int working_Hour = 0;
            Random r = new Random();
            while (No_Of_Working_Days < 20 && working_Hour < 100)
            {
                No_Of_Working_Days++;
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
                working_Hour += Emp_Hour;

                Emp_Wages += Emp_Hour * Emp_rate;

            }
            Console.WriteLine("Employee Wages: " + Emp_Wages);
           
        }
    }
}
