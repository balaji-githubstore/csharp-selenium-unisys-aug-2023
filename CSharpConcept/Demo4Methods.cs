using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unisys.MathConcept;

namespace CSharpConcept
{
    public class Demo4Methods
    {

        public static void Mainw(string[] args)
        {
            int radius = 10;

            double res = Area.AreaOfCircle(10);
            Console.WriteLine(res);

            res = Area.AreaOfCircle(20);
            Console.WriteLine(res);

            res = Area.AreaOfRectangle(10, 10.2);
            Console.WriteLine(res);

            Console.WriteLine(Area.AreaOfRectangle(20,20));

            //allocating the memory
            Area obj =new Area(); 

            res = obj.AreaOfTriangle(25, 1);
            Console.WriteLine(res);

            //Console.WriteLine(25/2);

            string name=obj.GetAuthorName();
            Console.WriteLine(name);

            obj.Quit();
     
        }
    }
}
