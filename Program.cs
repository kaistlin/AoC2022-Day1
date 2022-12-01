using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace AoC
{
    class AoCDay1
    {
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines
            (@"C:\Users\kaist\source\repos\AoC2022-Day1\day1input.txt");
            int[] elves = new int[lines.Length];
            int i = 0;
            foreach (string line in lines)
            {

                if (line != "")
                {
                    elves[i] += Int32.Parse(line);
                }
                else
                    i++;
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("\t" + "Done adding elves" + "\t");
            Array.Sort(elves);
            int n = elves.Length;
            int topThree = elves[n-1] + elves[n-2] + elves[n-3];

            Console.WriteLine("The three hungriest elves have " + topThree + " calories");
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}