using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomOperators
{
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public static bool operator ==(Rectangle x, Rectangle y)
        {
            return x.Width == y.Width && x.Height == y.Height;
        }

        public static bool operator !=(Rectangle x, Rectangle y)
        {
            return x.Width != y.Width || x.Height != y.Height;
        }

        public static Rectangle operator +(Rectangle x, Rectangle y)
        {
            return new Rectangle(x.Width + y.Width, x.Height + y.Height);
        }
    }
}
