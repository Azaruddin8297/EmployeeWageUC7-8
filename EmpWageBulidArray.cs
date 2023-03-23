using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmpWageBulidArray
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        public EmpWageBulidArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWages(string company, int empRatePerHour , int numOfWorkingDays,int maxHoursperMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursperMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for(int i = 0; i<numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpwage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].tostring());

            }
        }
        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalworkingdays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalworkingdays < companyEmpWage.numOfWorkingDays)
            {
                totalworkingdays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;


                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day # :" + totalworkingdays + "Emp Hrs :" + empHrs);

            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;

        }

    }

}
