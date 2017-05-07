using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectA = new Rectangle(10.0, 20.0);
            Rectangle rectB = new Rectangle(15.0, 30.0);

            if (rectA == rectB)
            {
                Console.WriteLine("Rectangle A has the same sizes of rectangle B.");
            }
            else if (rectA != rectB)
            {
                Console.WriteLine("Rectangle A has different sizes from rectangle B.");
            }

            var rectC = rectA + rectB;
            Console.WriteLine(string.Format("Rectangle C: Width {0}, Height {1}.", rectC.Width, rectC.Height));

            Console.ReadKey();
            
        }
    }
}
