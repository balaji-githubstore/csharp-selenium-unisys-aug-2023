using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unisys.EmployeeMangemenet;

namespace CSharpConcept
{
    public class Demo6EmployeeTest
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine(@"C:\mine");
            Employee.companyName = "Unisys";

            Employee emp1 = new Employee(101);
            Employee emp2 = new Employee(102);
            Employee emp3 = new Employee(103);
            Employee emp4= Employee.GetEmployeeInstance();

            emp4.DisplayEmployeeDetail();

            //Employee[] emps = new Employee[3];
            //emps[0]= emp1;

            //emp1.id = -101;
            emp1.name = "saul";
            emp1.salary = 9000;
            emp1.performance = "B";

            emp1.Id = 101; //write

            //load second object  (102,kim,6000,A,Unisys)
            //emp2.id = 102;
            emp2.name = "kim";
            emp2.salary = 6000;
            emp2.performance = "A";

            emp2.Id = -10;

            //load third object (103,peter,4000,C,Unisys)
            //emp3.id = 103;
            emp3.name = "peter";
            emp3.salary = 4000;
            emp3.performance = "C";

            emp3.Id = 103;



            emp3.DisplayEmployeeDetail();
            emp2.DisplayEmployeeDetail();
            emp1.DisplayEmployeeDetail();


            emp2.CaluclateBonus();

            emp2.DisplayEmployeeDetail();

            Console.WriteLine(emp2.Id); //read 

        }
    }
}
