using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    class Constructors
    {
        //overloading of constructors when the type of arguments are different
        class ADD
        {
            int x, y;
            double j;
            string t;

            public ADD(int a, double b)
            {
                x = a;
                j = b;
            }
            public ADD(int a, string b)
            {
                y = a;
                t = b;  
            }

            public void show()
            {
                Console.WriteLine("1st contructor (int+float): {0}", (x + j));
            }
            public void show1()
            {
                Console.WriteLine("2nd constructor (int+string):{0}",(y + t));
            }

        }

        class GFG
        {
            static void Main()
            {
                ADD g = new ADD(70, 58.3);
                g.show();

                ADD q = new ADD(70, "ID No. is");
                q.show();
            }
        }
    }
}



