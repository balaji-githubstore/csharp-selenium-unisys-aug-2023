using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.EmployeeMangemenet
{
    public class Employee
    {
        private int id;
        public string name;
        public double salary;
        public string performance;
        public static string companyName;

        public Employee()
        {

        }

        public Employee(int id)
        {
            this.id = id;
            Console.WriteLine("Object created ");
            Console.WriteLine("Launch browser");
        }

        public Employee(int id,string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("Object created ");
            Console.WriteLine("Launch browser");
        }

        public Employee(string name, int id)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("Object created ");
            Console.WriteLine("Launch browser");
        }
        public Employee(double id)
        {
            
        }

        public int Id
        {
            get 
            { 
                return id; 
            }
            set { 
                if(value>=100)
                {
                    id=value;
                }
                else
                {
                    Console.WriteLine("Invalid Id - Default value remains!!");
                }
            }
        }

        public void DisplayEmployeeDetail()
        {
            Console.WriteLine("Employee Id: " + this.id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Salary: " + salary);
            Console.WriteLine("Employee Performance: " + performance);
            Console.WriteLine("CompanyName: " + Employee.companyName);
            Console.WriteLine("-------------------------");
        }

        public void CaluclateBonus()
        {
            if (performance.Equals("A"))
            {
                Console.WriteLine("1000 as bonus for " + name);
                salary = salary + 1000;
            }
            else if (performance.Equals("B"))
            {
                Console.WriteLine("500 as bonus for " + name);
                salary = salary + 500;
            }
            else
            {
                Console.WriteLine("No bonus for " + name);
            }
        }


        public static Employee GetEmployeeInstance()
        {
            Employee e = new Employee(104);
            return e;
        }
    }
}
