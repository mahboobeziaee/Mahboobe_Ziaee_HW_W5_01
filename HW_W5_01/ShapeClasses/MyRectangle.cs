using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W5_01.ShapeClasses
{
    public sealed class MyRectangle:Shape
    {
        private double _length;
        private double _width;

        public MyRectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public void GetPerimeter()
        {
            base.GetPerimeter();
            Console.WriteLine();
            Console.WriteLine("Child Perimeter : "+ 2 * (_length + _width));
        
        }

        public void GetArea()
        {
            base.GetArea();
            Console.WriteLine();
            Console.WriteLine("Child Area : " + _length * _width);
           
        }
    }
}
