using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace width_and_input_program
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int x;

                Console.Write("Enter a number: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}{0}{0}", x);
                Console.WriteLine("{0} {0}", x);
                Console.WriteLine("{0} {0}", x);
                Console.WriteLine("{0} {0}", x);
                Console.WriteLine("{0}{0}{0}", x);
            }
        }

    }
}
