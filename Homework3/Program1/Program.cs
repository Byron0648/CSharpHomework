using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public abstract class Shape
{
    public abstract double Area { get; }

    public virtual void ShowArea()
    {
        Console.WriteLine("The Area of the shape is...");
    }

}
public class Square : Shape
{
    public double side = 0;

    public Square(double side)
    {
        this.side = side;
        Console.WriteLine("This is a square.");
    }

    public override double Area
    {
        get
        {
            return side * side;
        }
    }

    public override void ShowArea()
    {
        Console.WriteLine("The area of the Square is " + Area);
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
        Console.WriteLine("This is a circle.");
    }

    public override double Area
    {
        get
        {
            return 3.1415926 * radius * radius;
        }
    }

    public override void ShowArea()
    {
        Console.WriteLine("The area of the Cicle is "+Area);

    }
} 

public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width,double height)
    {
        this.width = width;
        this.height = height;
        Console.WriteLine("This is a rectangle.");
    }
    public override double Area
    {
        get
        {
            return width * height;
        }
    }

    public override void ShowArea()
    {
        Console.WriteLine("The area of the Rectangle is " + Area);
    }
}

public class Triangle : Shape
{
    private double side1 = 0;
    private double side2 = 0;
    private double side3 = 0;

    public Triangle(double side1,double side2,double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
        Console.WriteLine("This is a triangle.");
    }

    public override double Area
    {
        get
        {
            double a = (side1 + side2 + side3) / 2;
            return Math.Sqrt(a * (a - side1) * (a - side2) * (a - side3));
        }
    }

    public override void ShowArea()
    {
        Console.WriteLine("The area of the Triangle is " + Area);
    }
}

public class ShapeFactory
{
    public static Shape getShape(string type,double[]A)
    {
        Shape shape = null;
       
        switch(type)
        {
            case "Square":
                shape = new Square(A[0]);
                break;
            case "Circle":
                shape = new Circle(A[0]);
                break;
            case "Rectangle":
                shape = new Rectangle(A[0],A[1]);
                break;
            case "Triangle":
                shape = new Triangle(A[0],A[1],A[2]);
                break;


        }

        return shape;
    }
        

}


namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = { 3.0, 4.0,5.0 };
            Shape shape;
            shape = ShapeFactory.getShape("Square", A);
            shape.ShowArea();
            shape = ShapeFactory.getShape("Circle",A);
            shape.ShowArea();
            shape = ShapeFactory.getShape("Rectangle",A);
            shape.ShowArea();
            shape = ShapeFactory.getShape("Triangle",A);
            shape.ShowArea();
        }
    }
}
