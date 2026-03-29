using System;

public class Program
{
    public static void Main()
    {
    
       
            Circle circle = new Circle();
            Square square = new Square();
            Triangle triangle = new Triangle();
       
        
            Console.WriteLine(circle.Draw()); 
            Console.WriteLine(triangle.Draw()); 
            Console.WriteLine(square.Draw()); 

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