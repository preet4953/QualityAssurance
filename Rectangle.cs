using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As2ConsoleApp
{
    class Rectangle
    {
            private int length,width,height;

            public Rectangle()
            {
                this.length = 1;
                this.width = 1;
                this.height = 1;
            }

            public Rectangle(int length, int width, int height)
            {
                this.length = length;
                this.width = width;
                this.height = height;
            }

            public int GetLength()
            {
                return this.length;
            }

            public void SetLength(int length)
            {
                this.length =length;
            }

            public int GetWidth()
            {
                return this.width;
            }

            public void SetWidth(int width)
            {
                this.width =width;
            }

            public int GetHeight()
            {
                return this.height;
            }

            public void SetHeight(int height)
            {
                this.height =height;
            }

            public int GetVolume()
            {
            return this.length * this.width * this.height; 
            }
    }
}

