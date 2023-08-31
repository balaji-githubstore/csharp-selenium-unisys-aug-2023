using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    class Father
    {
        public int fAge = 60;

        public Father(int f) 
        {
            fAge = f;
            Console.WriteLine("Father constructor");
        }

        public void FatherStyle()
        {
            Console.WriteLine("father style!!!");
        }
    }
    class Son : Father
    {
        public int SAge = 20;

        public Son(int f,int s):base(f) 
        {
            SAge = s;
            Console.WriteLine("Son Constructor");
        }
        public void SonStyle() 
        {
            //Console.WriteLine(base.fAge);
            //base.FatherStyle();
            Console.WriteLine("son style");
        }
    }

    public class Demp9Inheritance
    {
        public static void Main(String[] args)
        {
            //Father f=new Father();
            //Console.WriteLine(f.fAge);
            //f.FatherStyle();

            Son s=new Son(70,30);

            Console.WriteLine(s.fAge);
            Console.WriteLine(s.SAge);

            s.FatherStyle();
            s.SonStyle();

        }
    }
}
