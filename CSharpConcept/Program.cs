using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionProject
{
    class Program
    {
        static void Main2(string[] args)
        {

            Console.WriteLine("Balaji Dinakaran!!!!!");

            byte a = 10; //a is reserved for byte -> 1 byte (8 bits)
            int b = 10; //b is reserved for int --> 4 byte (32 bits)
            long c = 10; //8 byte (64 bits)
            char d = 'r'; //16 bits 
            bool check = true;
            float f = 10.2f; //32 bits
            double g = 10.2; //64 bits

            Console.WriteLine(a);

            String myName = "Balaji"; //6*16 bits

            long result = b + c;
            Console.WriteLine(result);

            int radius = 10;

            //calculate area of circle and print it
            double output = 3.14 * radius * radius;
            Console.WriteLine("The result is " + output);



            String name = "Balaji";
            Console.WriteLine(name[1]);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());


            //5 marks
            int[] numbers = new int[5]; //5*32 bits
            numbers[0] = 45;
            numbers[1] = 44;
            numbers[2] = 43;

            Console.WriteLine(numbers);
            Console.WriteLine(numbers[1]);


            //red,green,yellow
            string[] colors = new string[3];
            colors[0] = "red";
            colors[1] = "green";

            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);

            colors = new string[4];

            Console.ReadLine();

        }
    }
}
