namespace EmployeeWage
{
    public class Employee
    {
        public static void Main(string[] args)
        {
            //EmpWageBulidArray empWageBulidArray = new EmpWageBulidArray();
            //empWageBulidArray.addCompanyEmpWages("DMart", 200, 20, 100);
            //empWageBulidArray.addCompanyEmpWages("Rliance", 300, 20, 10);
            //empWageBulidArray.computeEmpWage();
            Console.WriteLine("Welcome To Employee Wage Computation Program.");
            EmployeeWage.MonthlyEmployeeWage("Brand Factory", 50, 20, 130);
            EmployeeWage.MonthlyEmployeeWage("Dell Technologies", 90, 20, 150);


        }
    
    }
}
