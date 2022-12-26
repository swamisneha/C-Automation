
namespace Maveric.Runner
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Employee Dashboard----------");
            Employee.companyName = "Maveric";
            Employee.companyLocation = ("Chennai");

            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();
            Employee emp4 = new Employee();

            emp1.empId = 101;
            emp1.empName = "saul";
            //emp1.empSalary = 9000;
            emp1.empPerformanceType = 'B';
            emp1.EmpSalary = 9000;

            
            emp2.empId = 102;
            emp2.empName = "Kim";
            //emp2.empSalary = 12000.2;
            emp2.empPerformanceType = 'A';
            emp2.EmpSalary = 8900.2;
           

            emp3.empId = 103;
            emp3.empName = "Jack";
            //emp3.empSalary = 6000;
            emp3.empPerformanceType = 'C';
            emp3.EmpSalary = 45545.55;

            Employee.companyName = "Maveric Systems";
            
            emp1.PrintEmployeeDetail();
            emp2.PrintEmployeeDetail();
            emp3.PrintEmployeeDetail();

            emp1.DisplayGetGrossSalarywithBonus();
            emp2.DisplayGetGrossSalarywithBonus();
            emp3.DisplayGetGrossSalarywithBonus();
            emp4.DisplayGetGrossSalarywithBonus();


            //
            Console.WriteLine(emp3.EmpSalary);
        }
    }
}
