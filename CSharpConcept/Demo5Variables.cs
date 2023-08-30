using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo5Variables
    {
        public static int aS = 10; //static variable or class variable
        public static int bS = 20;

        public int aNS = 10; //non-static variable or instance variable
        public int bNS = 20;

        public static void Main3(string[] args)
        {
            Demo5Variables.aS = 1000;
            Console.WriteLine(Demo5Variables.aS);
            Console.WriteLine(Demo5Variables.bS);

            Demo5Variables obj1=new Demo5Variables();
            Demo5Variables obj2=new Demo5Variables();

            obj1.aNS = 1000;
            Console.WriteLine(obj1.aNS);
            Console.WriteLine(obj1.bNS);

            Console.WriteLine(obj2.aNS);
            Console.WriteLine(obj2.bNS);
        }
    }
}
