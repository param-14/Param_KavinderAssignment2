using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private int length, width;
        private int area, permeter;
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        public Rectangle(int Length, int Width)
        {
            length = Length;
            width = Width;
        }
        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetArea()
        {
            area = width * length;
            return area;
        }
        public int GetPerimeter()
        {
            permeter = 2 * (length + width);
            return permeter;
        }
    }
}
