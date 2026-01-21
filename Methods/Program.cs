using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning" + name);
        }
        static float Average(int a, int b, int c)
        { 
          float sum = a + b + c;
            return sum / 3;
        }
        static float Average(int a, int b)
        { 
         
            return ( a + b) /2;
        }
        static void Main(string[] args)
        {
            Greet ("sudarshan");
            Greet("sandesh");
            Console.WriteLine(Average(2, 6, 8));
            float temp = Average(9, 3, 0);
            Console.WriteLine(temp);
            Console.WriteLine(Average(3, 3, 3));
            Console.WriteLine(Average(3, 3));
            Console.ReadLine();

        }
    }
}
