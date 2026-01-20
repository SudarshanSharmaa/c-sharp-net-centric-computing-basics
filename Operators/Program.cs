using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Arithmetic operators
            int a = 6;
            int b = 2;
            Console.WriteLine("The value of a + b is:" + (a+b));
            Console.WriteLine("The value of a - b is:" + (a-b));
            Console.WriteLine("The value of a / b is:" + (a/b));
            Console.WriteLine("The value of a * b is:" + (a*b));
            //Console.ReadLine();

            // 2.Assignment operators
            int c = 6;
            int d = c;
            d += 2;
            Console.WriteLine(d);

            // 3.Logical operators
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //console.WriteLine(!false)
            //console.WriteLine(!true)           

            // 4.comparision operator
            Console.WriteLine(344 == 355);
            Console.WriteLine(344 < 355);
            Console.ReadLine();
        }
    }
}
