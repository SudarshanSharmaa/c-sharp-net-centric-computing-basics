using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            player rohit = new player();
            Console.WriteLine(rohit.getHealth());
            rohit.setHealth(36);
            Console.WriteLine(rohit.getHealth());
            Console.ReadLine();
        }
    }
}
