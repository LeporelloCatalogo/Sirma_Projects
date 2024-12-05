using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Shape_Area_Aalculator
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        public override double GetPerimeter()
        {
            return 2 * (Math.PI * Radius);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle - radius: {Radius}  Area: {GetArea()}  Perimeter: {GetPerimeter()}");
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return (Width * Height);
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle - width: {Width} height: {Height}  Area: {GetArea()}  Perimeter: {GetPerimeter()}");
        }

    }

    public class Triangle : Shape
    {
        public double a {  get; set; }
        public double b { get; set; }

        public double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return area;
        }

        public override double GetPerimeter()
        {
            return a + b + c;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Triangle - A: {a} B: {b} C: {c}  Area: {GetArea()}  Perimeter: {GetPerimeter()}");
        }
    
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            this.Side = side;
        }

        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimeter()
        {
            return Side * 4;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Square - Side: {Side}  Area: {GetArea()}  Perimeter: {GetPerimeter()}");
        }
    }

    public class Trapezoid : Shape
    {
        public double a {  get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }
        public double h { get; set; }

        public Trapezoid(double a, double b, double c, double d, double h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.h = h;
        }

        public override double GetPerimeter()
        {
            return a + b + c + d;
        }

        public override double GetArea()
        {
            return ((a + b) * h) / 2;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Trapezoid - A: {a} B: {b} C: {c} D: {d}  Area: {GetArea()}  Perimeter: {GetPerimeter()}");
        }
    }


    public class RegularPentagon : Shape
    {
        public double Side { get; set; }

        public RegularPentagon(double side)
        {
            Side = side;
        }

        public override double GetPerimeter()
        {
            return Side * 5;
        }

        public override double GetArea()
        {
            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(Side, 2);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Regular Trapezoid - Side: {Side}  Area: {GetArea()}  Perimeter: {GetPerimeter()}");
        }
    }

}
