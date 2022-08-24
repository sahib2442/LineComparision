using System;
namespace LineComparision
{
    internal class program
    {
        static void main(string[]args)
        {
            Comparision comparision = new Comparision(1,2,3,4)
            double line1 = comparision.CalculateLength();
            Console.WriteLine("length of the first line" + line1);
            Comparision lineComparision = new Comparision(1, 2, 3, 4);
            double line2 = lineComparision.CalculateLength();
            Console.WriteLine("lengrt of second line" + line2);
            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("Both line are same");
            if (line1.CompareTo(line2) > 0)
                Console.WriteLine("line1 is greater then line2");            
            else
            {
                Console.WriteLine("line2 is greater then line1");
            }
        }
    }
}
