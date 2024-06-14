using HW_W5_01.ShapeClasses;
using HW_W5_01.TriangleClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W5_01
{
    internal class HandelInput
    {
        public void LearningManagement()
        {
            var mainMessage = "Learning management system";
            Console.WriteLine(mainMessage);
            Console.WriteLine("".PadLeft(mainMessage.Length, '*'));
            Console.WriteLine("[1] Rectangle".PadRight(50) + "[2] Square");
            Console.WriteLine("[3] Right Triangle(Input int)".PadRight(50) + "[4] Right Triangle(Input decimal)");
            Console.WriteLine("[5] Isosceles Triangle(Input int)".PadRight(50) + "[6] Isosceles Triangle(Input decimal)");

            Console.WriteLine("".PadLeft(mainMessage.Length, '*'));
            Console.Write("Select: > ");
           
            var input = Console.ReadLine();
            try
            {



                switch (input)
                {
                    case "1":


                        Console.WriteLine("Enter length:");
                        double recLength = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter with:");
                        double recWith = Convert.ToDouble(Console.ReadLine());

                        MyRectangle rec = new MyRectangle(recLength, recWith);
                        rec.GetPerimeter();
                        Console.WriteLine(  );
                        rec.GetArea();

                        Console.WriteLine("".PadLeft(50, '*'));
                        break;

                    case "2":
                        Console.WriteLine("Enter length:");
                        double sqrLength = Convert.ToDouble(Console.ReadLine());
                        
                        MySquare sqr = new MySquare(sqrLength);
                        sqr.GetPerimeter();
                        Console.WriteLine( );
                        sqr.GetArea();

                        Console.WriteLine("".PadLeft(50, '*'));

                         break;

                        case "3":
                        Console.WriteLine("Enter side1:");
                        int side1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side1:");
                        int side2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side1:");
                        int side3 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Input int:");
                        RightTriangle rightTri = new RightTriangle(side1, side2, side3);
                        rightTri.GetArea();
                        Console.WriteLine();
                        rightTri.GetPerimeter();
                        Console.WriteLine("".PadLeft(50, '*'));

                        break;
                        case "4":
                        Console.WriteLine("Enter side1:");
                        decimal sideA = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side1:");
                        decimal sideB = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side1:");
                        decimal sideC = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Input int:");
                        RightTriangle rightTriDec = new RightTriangle(sideA, sideB, sideC);
                        rightTriDec.GetArea();
                        Console.WriteLine();
                        rightTriDec.GetPerimeter();
                        Console.WriteLine("".PadLeft(50, '*'));

                        break;
                        case "5":
                        Console.WriteLine("Enter side1:");
                        int side1isoscTri = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side1:");
                        int side2isoscTri = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side1:");
                        int side3isoscTri = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Input int:");
                        IsoscelesTriangle isoscTri = new IsoscelesTriangle(side1isoscTri, side2isoscTri, side3isoscTri);
                        isoscTri.GetArea();
                        Console.WriteLine();
                        isoscTri.GetPerimeter();
                        Console.WriteLine("".PadLeft(50, '*'));
                        break;
                        case "6":
                        Console.WriteLine("Enter side1:");
                        int sideAisoscTri = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side1:");
                        int sideBisoscTri = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter side1:");
                        int sideCisoscTri = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Input int:");
                        IsoscelesTriangle isoscTri2 = new IsoscelesTriangle(sideAisoscTri, sideBisoscTri, sideCisoscTri);
                        isoscTri2.GetArea();
                        Console.WriteLine();
                        isoscTri2.GetPerimeter();
                        Console.WriteLine("".PadLeft(50, '*'));
                        break;

                    default:
                        throw new ArgumentException($"Selected option is not valid. Your input: {input}");
                }
            }
            catch (Exception ex)
            {
                LearningManagement();
                
            }

        }
    }
}
