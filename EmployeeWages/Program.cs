using System;

namespace EmployeeWages
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject empWageBuilderObject = new EmpWageBuilderObject();
            empWageBuilderObject.addCompanyEmpWage("DMart", 20, 15, 100);
            empWageBuilderObject.addCompanyEmpWage("Reliance", 10, 20, 200);
            empWageBuilderObject.computeEmpWage();
        }
    }
}
