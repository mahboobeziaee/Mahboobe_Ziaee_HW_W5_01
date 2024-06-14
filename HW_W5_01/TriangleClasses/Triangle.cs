using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W5_01.TriangleClasses
{
    public class Triangle
    {
        public virtual void GetPerimeter()
        {
            Console.WriteLine("The method get Perimeter of parent(Triangle)...");
        }

        public virtual void GetArea()
        {
            Console.WriteLine("The method get Area of parent(Triangle)...");
        }
    }
}
