using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_class_and_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Math class
            //int a = Math.Max(34, 344);
            int a = Math.Min(34, 344);
            //double x = Math.Sqrt(36);
            //Console.WriteLine(x);
            //Console.WriteLine(a);

            // String class
            //string hello = "Hello World this is sudarshan";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello +  " You are nice");
            //Console.WriteLine(string.Concat(hello, "You are nice"));

            //string interpolation
            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}. You will get candies {candies} candies");


            string hello = "Hello World \"this is sudarshan";
            //Console.WriteLine(hello[5]);
            Console.WriteLine(hello.IndexOf("is"));
            Console.WriteLine(hello.Substring(5));
            Console.WriteLine(hello);
            Console.ReadLine();
        }
    }
}
