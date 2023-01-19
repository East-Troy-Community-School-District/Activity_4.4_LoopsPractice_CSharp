/*
 * While Loop Debug 
 * 1/19/2023
 * C#.NET I
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinFlip;
            string flipAgain = "Y";
            Random randomGen = new Random();
            while (flipAgain == "Y")
            {
                coinFlip = randomGen.Next(0, 2);
                if (coinFlip == 0)
                {
                    Console.WriteLine("Heads!");
                }
                else
                {
                    Console.WriteLine("Tails!");
                }
            }
        }
    }
}
