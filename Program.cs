namespace EmployeeWage
{
    public class Employee
    {
        public static void Main(string[] args)
        {
            EmpWageBulidArray empWageBulidArray = new EmpWageBulidArray();
            empWageBulidArray.addCompanyEmpWages("DMart", 200, 20, 100);
            empWageBulidArray.addCompanyEmpWages("Rliance", 300, 20, 120);
            empWageBulidArray.computeEmpWage();


        }
    
    }
}
