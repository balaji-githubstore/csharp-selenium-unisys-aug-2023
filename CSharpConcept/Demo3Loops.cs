using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo3Loops
    {
        public static void Main3(string[] args)
        {
            //1 to 10
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int[] numbers = { 10, 50, 68, 7, 25, 65, 45, 41, 56, 65 };

            Console.WriteLine(numbers.Length);

            //0 to 8
            //print value that are less than or equal to 50 from the array
            //using for loop

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] <= 50)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            string[] fruits = { "mango", "orange", "apple", "jackfruit" };

            //print each value using foreach loop
            foreach (string fruit in fruits)
            {
                if (fruit.Equals("orange"))
                {
                    Console.WriteLine("yes, orange is present");
                    break;
                }
            }

            //foreach (string fruit in fruits)
            //{
            //    if (fruit.Equals("orange"))
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(fruit);
            //}
        }
    }
}
