using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo7Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + c + b);
        }

        public void Add(int a, double b)
        {
            Console.WriteLine(a + b);
        }

        public void Add( double b, int a)
        {
            Console.WriteLine(a + b);
        }
    }
}
