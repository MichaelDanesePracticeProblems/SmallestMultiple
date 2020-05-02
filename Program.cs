using System;
using System.Collections.Generic;

namespace SmallestMultiple
{
    class Program
    {
        /*
         2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        */
        //Michael Danese
        static void Main(string[] args)
        {
            int min = 1, max = 20, j = max;
            bool divisible = false, found = false;
            List<int> checkList = new List<int>();
            checkList.Add(max);
            for (int i = max - 1; i > min - 1; i--)
            {/*
                Just a section to make the program more scalable. 
                Takes the numbers that cannot be divided by even smaller numbers and puts them into a list to compare to every interval of the max.
             */
                divisible = false;
                foreach (int element in checkList)
                {
                    if (element % i == 0)
                    {
                        divisible = true;
                        break;
                    }
                }
                if (!divisible)
                {
                    checkList.Add(i);
                }
            }
            while (!found)
            {
                divisible = true;
                foreach (int element in checkList)
                {
                    if (j % element != 0)
                    {
                        divisible = false;
                        break;
                    }
                }
                if (divisible)
                {
                    found = true;
                }
                else
                {
                    j += max;
                }
                
            }
            Console.Write("The smallest number that is evenly divisible by each of the numbers between ");
            Console.Write(min);
            Console.Write(" and ");
            Console.Write(max);
            Console.Write(" is ");
            Console.WriteLine(j);
        }
    }
}
