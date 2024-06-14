using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W5_01.TriangleClasses
{
    public sealed class RightTriangle:Triangle
    {
        protected decimal baseSide { get; set; }
        protected decimal heightSide { get; set; }
       
        public decimal _side1,_side2, _side3;
        public RightTriangle( int side1, int side2, int side3)
        {
                _side1 =Convert.ToDecimal( side1);
            _side2 =Convert.ToDecimal( side2);
            _side3 =Convert.ToDecimal( side3);
        }
        public RightTriangle(decimal side1,decimal side2,decimal side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            
        }
        public override  void GetPerimeter()
        {
            base.GetPerimeter();
            Console.WriteLine();
            Console.WriteLine($"The perimeter of right triangle is(child): " + (_side1+_side2+_side3));
        }

        public void GetPerimeter(int inputOverload)
        {
            Console.WriteLine("The method is my GetPerimeter Overloading");
        }
        public override void GetArea()
        {
            base.GetArea();
            Console.WriteLine();
            if ((_side1 > _side2) && (_side1 > _side3))
            {
                baseSide = Convert.ToDecimal(_side3);
                
                heightSide = Convert.ToDecimal(_side2);
            }
            else if ((_side2 > _side1) && (_side2 > _side3))
            {
                baseSide = Convert.ToDecimal(_side1);

                heightSide = Convert.ToDecimal(_side3);
            }
            else if ((_side3 > _side1) && (_side3 > _side2))
            {
                baseSide = Convert.ToDecimal(_side1);

                heightSide = Convert.ToDecimal(_side2);
            }
            decimal area = ((baseSide * heightSide) / 2);

            Console.WriteLine($"The area of right triangle is(child): " + area);
        }

        public void GetArea(int input)
        {
            Console.WriteLine("The method is my GetArea Overloading");
        }
    }
}
