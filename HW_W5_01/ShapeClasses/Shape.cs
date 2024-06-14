using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W5_01.ShapeClasses
{
    public class Shape
    {
        public virtual void GetPerimeter()
        {
            Console.WriteLine("The method get Perimeter of parent(Shape)...");
        }

        public virtual void GetArea()
        {
            Console.WriteLine("The method get Area of parent(Shape)...");

        }
    }
}
