using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LineComparision
{
    public class LineComparision
    {
        int x1, y1, x2, y2;
        public Comparison(int_x1, int_x2, int_y1, int_y2)
        {
            this.x1 = _x1;
            this.y1 = _y1;
            this.x2 = _x2;
            this.y2 = _y2;
        }
        public void CalculateLength()
        {
            double LineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(LineLength);
        }
    }
}
