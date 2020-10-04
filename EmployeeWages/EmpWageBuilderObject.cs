using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EmployeeWages
{
    class EmpWageBuilderObject: IComputeEmpWage
    {
        public const int FULL_TIME = 2;
        public const int PART_TIME = 1;
        private LinkedList<CompanyEmpWage> companyEmpWageList;

        public EmpWageBuilderObject()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company,int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company,empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
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
                return   totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}
