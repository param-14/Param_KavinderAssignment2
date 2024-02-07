using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
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
            this.length = Length;
            this.width = Width;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetArea()
        {
            this.area = (this.width * this.length);
            return this.area;
        }
        public int GetPerimeter()
        {
            this.permeter = 2 * (this.length + this.width);
            return this.permeter;
        }
    }
}
