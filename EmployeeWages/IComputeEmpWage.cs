using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();
        void getTotalWageForAllCompany();
    }
}
