using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W5_01.ShapeClasses
{
    public sealed class MySquare:Shape
    {
        private double _length;

        public MySquare(double length)
        {
            _length = length;
        }

        public void GetPerimeter()
        {
            base.GetPerimeter();
            Console.WriteLine();
            Console.WriteLine($"Child Perimeter : " + (4 * _length));
         
        }

        public void GetArea()
        {
            base.GetPerimeter();
            Console.WriteLine();
            Console.WriteLine("Child Area : "+ (_length * _length));
            
        }
    }
}
