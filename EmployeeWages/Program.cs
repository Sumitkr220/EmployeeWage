using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 10, 200);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 15, 20, 100);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
