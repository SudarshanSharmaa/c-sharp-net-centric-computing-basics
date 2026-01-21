using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While loop
            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //}

            // dowhile loop
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //}
            //while(i < 5);

            //for loop
            for (int i = 0; i < 5; i++)
            { 
                if (i == 0)
                {
                    continue;
                }
            Console.WriteLine(i + 1);
            //break;
            
          }
            Console.ReadLine();

        }
    }
}
