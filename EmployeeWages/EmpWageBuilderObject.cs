using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EmployeeWages
{
    class EmpWageBuilderObject
    {
        public const int FULL_TIME = 2;
        public const int PART_TIME = 1;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWagesArray;

        public EmpWageBuilderObject()
        {
            this.companyEmpWagesArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company,int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWagesArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }

        public void computeEmpWage()
        {
            for(int i=0;i<numOfCompany;i++)
            {
                companyEmpWagesArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWagesArray[i]));
                Console.WriteLine(this.companyEmpWagesArray[i].toString());
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