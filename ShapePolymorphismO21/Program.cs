using System;

public class Program
{
    public static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Circle(),
            new Square(),
            new Triangle()
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Draw()); //the method call inside the writeline 
            // stays generic because the name is replaced each time, 
            // using the list loop keeps you from copy pasting for each shape
        }
    }
}

public abstract class Shape
{
    protected abstract string Name { get; }

    public string Draw()
    {
        return $"Shaper is drawing a {Name}";
    }
}

public class Circle : Shape
{
    protected override string Name => "circle";
}

public class Square : Shape
{
    protected override string Name => "square";
}

public class Triangle : Shape
{
    protected override string Name => "triangle";
}
