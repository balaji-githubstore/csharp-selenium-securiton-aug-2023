using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Program2
    {

        public static void Main1(string[] args) 
        {

            Employee.companyName = "Google";

            Employee.companyName = "Google2";

            Employee emp1=new Employee();
            Employee emp2 = new Employee();
            Employee emp3 = new Employee();

            Employee emp4= Employee.GetEmployeeInstance();


            emp1.EmpId = -101;
            emp1.empName = "Saul";
            emp1.empSalary = 9000;
            emp1.empPerformance = 'A';
          

            emp2.EmpId = 1002;
            emp2.empName = "Kim";
            emp2.empSalary = 8000;
            emp2.empPerformance = 'C';

            Console.WriteLine(emp1.EmpId);

            emp1.PrintEmployeeDetails();
            emp2.PrintEmployeeDetails();
            emp3.PrintEmployeeDetails();
            emp4.PrintEmployeeDetails();


            emp2.CalculateBonus();
            emp3.CalculateBonus();


            emp1.CalculateBonus();


            Employee.GetEmployeeInstance().PrintEmployeeDetails();



        }
    }
}
