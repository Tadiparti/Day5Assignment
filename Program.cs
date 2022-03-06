using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Constructors called.");
        }
        //destructors
        ~Program()
        {
            Console.WriteLine("Destructor called.");
        }

        public static void Main(string[] args)
        {

            //creates objects of Program
            Program p1 = new Program();
        }
    }
}
