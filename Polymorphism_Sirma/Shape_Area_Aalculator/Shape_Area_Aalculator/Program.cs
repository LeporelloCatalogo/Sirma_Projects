using Microsoft.VisualBasic;
using Shape_Area_Aalculator;
using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        /*string filepath = "Shapes.txt";
        MemoryManagement memory = new MemoryManagement(filepath);*/

        List<Shape> shapes = new List<Shape>();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("[1] Add Shapes");
            Console.WriteLine("[2] Remove Shape");
            Console.WriteLine("[3] List Shapes Info");
            Console.WriteLine("[4] Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddShapes(shapes);
                    //memory.Save(shapes);
                    break;

                case "2":
                    RemoveShape(shapes);
                    //memory.Save(shapes);
                    break;

                case "3":
                    ListAllShapes(shapes);
                    break;

                case "4":
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("No such command.");
                    break;
            }
        }

        /*List<Shape> shapes2 = memory.LoadShapes();
        ListAllShapes(shapes2);*/

    }

    public static void AddShapes(List<Shape> shapes)
    {
        Console.WriteLine("\nEnter a number of shapes to add:");
        double count = ValidateDoubleInput();

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nChoose a shape: \n" +
                "[1] Circle, \n [2] Rectangle, \n[3] Triangle, \n[4] Trapezoid, \n[5] Regular Pentagon");
            string choice = Console.ReadLine();

            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Radius:");
                    double radiusCircle = ValidateDoubleInput();
                    shapes.Add(new Circle(radiusCircle));
                    break;

                case "2":
                    Console.WriteLine("Width:");
                    double widthRectangle = ValidateDoubleInput();
                    Console.WriteLine("Height");
                    double heightRectangle = ValidateDoubleInput();
                    shapes.Add(new Rectangle(widthRectangle, heightRectangle));
                    break;

                case "3":
                    Console.WriteLine("Side A:");
                    double triangleA = ValidateDoubleInput();
                    Console.WriteLine("Side B:");
                    double triangleB = ValidateDoubleInput();
                    Console.WriteLine("Side C:");
                    double triangleC = ValidateDoubleInput();
                    shapes.Add(new Triangle(triangleA, triangleB, triangleC));
                    break;

                case "4":
                    Console.WriteLine("Upper horizontal side A:");
                    double trapezoidA = ValidateDoubleInput();
                    Console.WriteLine("Lower horizontal side B:");
                    double trapezoidB = ValidateDoubleInput();
                    Console.WriteLine("Left diagonal side C:");
                    double trapezoidC = ValidateDoubleInput();
                    Console.WriteLine("Right diagonal side D:");
                    double trapezoidD = ValidateDoubleInput();
                    Console.WriteLine("Height:");
                    double trapezoidHeight = ValidateDoubleInput();
                    shapes.Add(new Trapezoid(trapezoidA, trapezoidB, trapezoidC, trapezoidD, trapezoidHeight));

                    break;

                case "5":
                    Console.WriteLine("Side:");
                    double pentagonSide = ValidateDoubleInput();
                    shapes.Add(new RegularPentagon(pentagonSide));
                    break;

                default:
                    Console.WriteLine("No such shape!");
                    break;
            }
        }
    }

    public static void RemoveShape(List<Shape> shapes)
    {
        if (shapes.Count == 0)
        {
            Console.WriteLine("List of shapes is currently empty.");
            return;
        }

        ListAllShapes(shapes);

        while(true)
        {
            Console.WriteLine("\nEnter the number of the shape to remove:");
            int index = ValidateIntInput();
            if (index < shapes.Count)
            {
                shapes.RemoveAt(index);
                break;
            }
            else
            {
                Console.WriteLine("No such number in the list. Please try again.\n");
            }
        }
    }

    public static void ListAllShapes(List<Shape> shapes)
    {
        if (shapes.Count == 0)
        {
            Console.WriteLine("List of shapes is currently empty.");
            return;
        }

        Console.WriteLine();
        for (int i = 1; i <= shapes.Count; i++)
        {
            Console.WriteLine(string.Concat(i, "."));
            shapes[i-1].DisplayInfo();
        }
    }

    public static int ValidateIntInput()
    {
        int input;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else if (input <= 0)
            {
                Console.WriteLine("Input should be a positive number. Please try again:");
            }
            else
            {
                Console.WriteLine("Input should be a number. Please try again:");
            }
        }
    }
    public static double ValidateDoubleInput()
    {
        double input;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out input))
            { 
                return input;
            }
            else if (input <= 0)
            {
                Console.WriteLine("Input should be a positive number. Please try again:");
            }
            else
            {
                Console.WriteLine("Input should be a number. Please try again:");
            }
        }
    }


}