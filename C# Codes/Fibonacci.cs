using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class PrimeFactorization
    {
        static void Main(string[] args)
        {
            ulong first = 0, second = 1;

            string output = "[0]0\n[1]1";

            Console.WriteLine("Type the amount of iterations that you want to see, eg. '100'");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < amount - 1; i++)
            {
                output += string.Format("\n[{0}]{1}", i + 2, (first + second));

                ulong temp = first; //Memory of first to use for reference

                //  Use the left-overs like this:
                //  0, 1, 1, 2, 3, 5, 8 ...
                //  0(first), 1(second), --> (first = second = 1) + (second + first(or known as 'temp') = 1) == 2(second is now equal to '2'),
                //  --> (first = second = 1) + (second + first(or known as 'temp') = 2) == 3(second is now equal to '3')

                first = second;

                second += temp;
            }
            
            Console.WriteLine(output);
        }
    }
}
