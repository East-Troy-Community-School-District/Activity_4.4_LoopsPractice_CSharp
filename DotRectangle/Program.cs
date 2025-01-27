/*
 * Dot Rectangle
 * 1/26/2025
 * 
 * Instructions:
 * 1.   Trace the program and predict what it will display. Then run the program to
 *      check your work.
 * 2.   Modify the program so that is displays a rectangle of dots
 *      that is 5 dots tall and 3 dots wide.
 * 3.   What loop controls the number of rows?
 * 4.   What loop controls the number of columns?
 * 5.   What is the purpose of line 33 in the program?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)      // What does this loop add after each pass?
            {
                for(int j = 0; j < 5; j++)  // What does this loop add after each pass?
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
