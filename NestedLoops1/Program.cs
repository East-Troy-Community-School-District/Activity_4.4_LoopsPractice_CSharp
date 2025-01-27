/*
 * Nested Loops 1
 * 1/26/2025
 * 
 * Instructions:
 * 1.   Trace the program and predict what it will display. Then run the program to
 *      check your work.
 * 2.   Modify the program so the inner loop uses i as the loop control variable.
 *      What happens? Based on this, why is it important to use two different variables
 *      for the inner and outer loops?
 * 3.   In total, how many times does the inner loop repeat?
 * 4.   Does the outer loop control the left or right number? What about the inner loop?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoops1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i += 3)      // What does this loop add after each iteration?
            {
                for (int j = 0; j < 6; j += 2)  // What does this loop add after each iteration?
                {
                    Console.WriteLine(i + "\t" + j);    // What does the \t do in this line?
                }
            }
        }
    }
}
