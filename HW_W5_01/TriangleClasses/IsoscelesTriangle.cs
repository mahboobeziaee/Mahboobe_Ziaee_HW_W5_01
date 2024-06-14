using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W5_01.TriangleClasses
{
    public sealed  class IsoscelesTriangle :Triangle
    {
        protected decimal baseSide { get; set; }
        protected decimal  heightSide { get; set; }

        public decimal _side1, _side2, _side3;
        

        public IsoscelesTriangle(int side1, int side2, int side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }
        public IsoscelesTriangle(decimal side1, decimal side2, decimal side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;

        }
        public override  void GetPerimeter()
        {
            base.GetPerimeter();
            Console.WriteLine();
            Console.WriteLine($"The perimeter of Isosceles triangle is: " + (_side1 + _side2 + _side3));
        }
       
        public void GetPerimeter(int inputOverload)
        {
            Console.WriteLine("The method is my GetPerimeter Overloading");
        }


        public override  void GetArea()
        {
            base.GetArea();
            Console.WriteLine();
            if (_side2 == _side3)
            {
                baseSide =Convert.ToDecimal( _side1);
                var temp =Convert.ToDecimal( baseSide/2);
           
                heightSide =Convert.ToDecimal( Math.Sqrt(Convert.ToDouble(Math.Abs((_side2 * _side2) - (temp * temp)))));
               

            }
            else if ((_side2 == _side1))
            {
                baseSide = Convert.ToDecimal(_side1);
                var temp = Convert.ToDecimal(baseSide / 2);
                heightSide = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(Math.Abs((_side3 * _side3) - (temp * temp)))));
            }
            else if ((_side3 ==_side1))
            {
                baseSide = Convert.ToDecimal(_side2);
                var temp = Convert.ToDecimal(baseSide / 2);
                heightSide = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(Math.Abs((_side1 * _side1) - (temp * temp)))));
            }
            decimal area = ((baseSide * heightSide) / 2);

            Console.WriteLine($"The area of Isosceles triangle is: " + area);
        }


        public  void GetArea(int input)
        {
            Console.WriteLine(  "The method is my GetArea Overloading");
        }
    }
}
