using System;
using System.Collections.Generic;

namespace Longest_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise string list to search through
            int[] daily_sales = { 1, 2, 1, 1, 0, 3, 1, 0, 0, 2, 4, 1, 0, 0, 0, 0, 2, 1, 0, 3, 1, 0, 0, 0, 6, 1, 3, 0, 0, 0 };

            //initialise streaks
            List<int> streaks = new List<int>();

            int running_total = 0;

            //search rough string array
            foreach (int entry in daily_sales)
            {
                Console.WriteLine("entry = {0}", entry);

                //if entry is 0
                if (entry == 0)
                {
                    Console.WriteLine("0 detected");
                    ++running_total; //increment counter

                }
                else
                {
                    Console.WriteLine("not 0");
                    //append counter to streak list
                    streaks.Add(running_total);
                    //reset counter
                    running_total = 0;
                }
            }

            //find longest entry on streak array
            //print streak list
            Console.WriteLine("Printing streak list...");
            int maxVal = int.MinValue;
            foreach (int value in streaks)
            {
                Console.WriteLine(value);

                if (maxVal < value)
                {
                    maxVal = value;
                }
            }

            //print final length max streak
            Console.WriteLine("Length of max streak = {0}", maxVal);

        }
    }
}
