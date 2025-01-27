/*
 * Multiplication Table
 * 1/26/2025
 * 
 * Instructions:
 * 1.   Why did we print the first row and the border outside the loops first?
 * 2.   Add a breakpoint on line 31 and step through the program. What loop
 *      controls the number of rows displayed?
 * 3.   What loop controls the number of columns displayed?
 * 4.   Here is another way to look at the last two questions. What loop works
 *      across each row? What loop works across down the rows?
 * 5.   How are nested loops used to create 2D structures?
 * 6.   Why did we use a Console.Write on line 37.
 * 7.   On line 37 we used a formatted string. How does this formatted string work?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  |  0  1  2  3  4  5  6  7  8  9");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < 10; i++)        // Add the breakpoint here!
            {
                Console.Write(i + " |");
                for (int j = 0; j < 10; j++)
                {
                    int result = i * j;
                    Console.Write($"{result, 3}");
                }
                Console.WriteLine();
            }
        }
    }
}
