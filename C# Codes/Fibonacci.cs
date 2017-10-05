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
            long nmb1 = 0, nmb2 = 1;

            string str = "[0]0\n[1]1";

            Console.WriteLine("Type the amount of iterations that you want to see, eg. '100'");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            for (int i = 0; i < amount - 1; i++)
            {
                str += string.Format("\n[{0}]{1}", i + 2, (nmb1 + nmb2));

                long tmp1 = nmb1; //Remainder of number1 to use for reference

                //Use the left-overs like this:
                //0, 1, 1, 3, 3, 5, 8 ...
                //  0(nmb1), 1(nmb2), --> (nmb1=nmb2 = 1) + (nmb2 + nmb1(or known as 'tmp1') = 1) == 2(nmb2 is now equal to '2'),
                //  --> (nmb1=nmb2 = 1) + (nmb2 + nmb1(or known as 'tmp1') = 2) == 3(nmb2 is now equal to '3')

                nmb1 = nmb2;

                nmb2 += tmp1;
            }
            Console.WriteLine(str);
        }
    }
}