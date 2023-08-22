using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Employee
    {
        public int empId;
        public String empName;
        public double empSalary;
        public char empPerformance;
        public static String companyName;


        public void PrintEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name: "+empName);

            Console.WriteLine("Company Name:"+Employee.companyName);

            Console.WriteLine("---------------------------------");
        }

        public static Employee GetEmployeeInstance()
        {
            Employee e=new Employee();

            return e;
        }

        public void CalculateBonus()
        {

            double empSalary = 10;

            if(empPerformance=='A')
            {
                Console.WriteLine("Employee Name" + this.empName + " is getting 1000 as bonus");
                Console.WriteLine("1000");
                empSalary = this.empSalary + 1000;
                //Console.WriteLine(this.);
            }
            else if(empPerformance=='B')
            {
                Console.WriteLine("Employee Name" + empName + " is getting 500 as bonus");
                Console.WriteLine("500");
                empSalary = empSalary + 1000;
            }
            else
            {
                Console.WriteLine("Employee Name"+empName+" is getting 200 as bonus");
                Console.WriteLine("200");
            }
        }
    }
}





