using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your age");
            //string agestr = Console.ReadLine();
            //int age = Convert.ToInt32(agestr);
            //bool isBanned = true;

            //if (age < 2 || isBanned)
            //{
            //    Console.WriteLine("You are just born or banned");
            //}

            //else if (age < 10 || isBanned) 
            //{
            //    Console.WriteLine("Please finish your high school or may be you are banned");
            //}

            //else if (age < 18)
            //{
            //    Console.WriteLine("You are below 18");
            //}

            //else if (age < 75) 
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else
            //{ 
            //    Console.WriteLine("You cannot drive");

            //}


            int age = 20;

            switch(age)
            {
                case 18:
                    Console.WriteLine("Please wait for an year");
                    break;

                case 20:
                    Console.WriteLine("You are 20");
                    break;

                default:
                    Console.WriteLine("Enjoy!");
                    break;
            }
            Console.ReadLine();

        }
    }
}
