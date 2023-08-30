using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo2Logics
    {
        public static void Main2(string[] args)
        {

            int num = 10;

            if(num<0)
            {
                Console.WriteLine("the given value is negative = "+num);
            }
            else if(num==0)
            {
                Console.WriteLine("it's zero");
            }
            else
            {
                Console.WriteLine("the given value is positive = " + num);
            }


        }
    }
}
