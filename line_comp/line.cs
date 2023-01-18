using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line_comp
{
    internal class Line
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public double length()
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        }
        public void equality(Line other)
        {
            if(this.length() != other.length())
            {
                Console.WriteLine("Not Equal");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
        public void compare(Line other)
        {
            if(this.length()>other.length())
            {
                Console.WriteLine("This line is greater");
            }
            else if(this.length()<other.length())
            {
                Console.WriteLine("other line is greater");
            }
            else
            {
                Console.WriteLine("both are equal");
            }
        }

    }
}
