namespace EmployeeWage
{
    public class Employee
    {
        public static void Main(string[] args)
        {
            EmpWageBulidArray empWageBulidArray = new EmpWageBulidArray();
            empWageBulidArray.addCompanyEmpWages("DMart", 20, 2, 10);
            empWageBulidArray.addCompanyEmpWages("Reliance", 40, 2, 20);
            empWageBulidArray.computeEmpWage();


        }
    
    }
}
