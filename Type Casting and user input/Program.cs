using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //There are two types of casting
            // 1.Implict casting
           // int x=(int) 3.5
            double x1 = (double)3.5;
            Console.WriteLine(x1);

            //2.Explict casting
            int x = 3;
            double y = x;
            float z = 'y';
            float var = Convert.ToInt32(34.5);
            string sx = "Random String";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            //Console.ReadLine();

            // How to take input from user
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("hey hello" +name);
            Console.WriteLine("How many candies do you have?");
            string can = Console.ReadLine();
            Console.WriteLine("You get 4 candies:" + (Convert.ToInt32(can) + 4));
            Console.ReadLine();
        }
    }
}
