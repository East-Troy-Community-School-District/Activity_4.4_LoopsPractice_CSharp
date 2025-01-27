/*
 * Nested Loops 2
 * 1/26/2025
 * 
 * Instructions:
 * 1.   Trace the program and predict what it will display. Then run the program to
 *      check your work.
 * 2.   Compare the previous program and this program. How does the output differ?
 *      Why do you think this happened?
 * 3.   How many times does the inner loop repeat for each pass of the outer loop?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i = i + 3)       // What does this loop add after each iteration?
            {
                for (int j = 0; j < 6; j = j + 2)   // What does this loop add after each iteration?
                {
                    Console.WriteLine(j + "\t" + i);
                }
            }
        }
    }
}
