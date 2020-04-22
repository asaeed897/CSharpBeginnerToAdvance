using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle.");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle.");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle.");
        }
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // We can't drive a class from a sealed class
            // for making a class as a sealed class we just add modifier sealed at place of abstract
            // we can also sealed a method but that method should be override
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Triangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

            // 30 Sealed CLasses and Members
        }
    }
}
