﻿using System;
namespace LineComparision
{
    internal class program
    {
        static void main(string[]args)
        {
            LineComparision lineComProblem = new LineComparision(1,2,3,4)
            double line1 = lineComProblem.CalculateLength();
            Console.WriteLine("length of the first line" + line1);
            LineCompProblem lineCompProblem2 = new LineCompProblem(1, 2, 3, 4);
            double line2 = lineComProblem.CalculateLength();
            if (line1 == line2)
            {
                Console.WriteLine("line1 is equal to line2");
            }
            else
            {
                Console.WriteLine("line1 is not equal to line2");
            }
        }
    }
}
