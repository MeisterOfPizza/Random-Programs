using System;
using System.Collections.Generic;

/*
    Returns the numbers 'building blocks' that the input number is 'built' of.
    Language: C#
*/

namespace Prime_Factoring
{
    class Program
    {
        static void Main(string[] args)
        {
            newNumber:

            long number = Convert.ToInt64(Console.ReadLine());
            Console.Clear();

            if (number < 1)
            {
                Console.WriteLine("The input number must be over or atleast equal to 1");
                goto newNumber;
            }

            List<long> buildingBlocks = Factor(number);

            string output = "";

            if (buildingBlocks.Count > 1)
            {
                output = "The number " + number + " was built up by these numbers:\n";

                for (int i = 0; i < buildingBlocks.Count; i++)
                {
                    output += buildingBlocks[i].ToString();

                    if (i < buildingBlocks.Count - 1)
                    {
                        output += "*";
                    }
                }
            }
            else
            {
                output += number + " is a prime number!";
            }

            Console.WriteLine(output + "\nPress 'Enter' to continue...");

            Console.ReadLine();

            Console.Clear();
            goto newNumber;
        }

        static List<long> Factor(long n)
        {
            List<long> deviders = new List<long>();

            for (int i = 2; n > 1; i++)
            {
                while (n % i == 0)
                {
                    n /= i;
                    deviders.Add(i);
                }
            }

            return deviders;
        }
    }
}
