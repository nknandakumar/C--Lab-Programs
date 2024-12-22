using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface Shape
{
    void area();
}

public class Circle : Shape
{
    public void area()
    {
        Console.WriteLine("****** Calculating the Circle ********");
        Console.Write("Enter the Radius :- ");
        float r = float.Parse(Console.ReadLine());
        Console.WriteLine("Area of circle is = " + (3.142) * r * r);

    }
}

public class Sqaure : Shape
{
    public void area()
    {
        Console.WriteLine("****** Calculating the Square ******** ");
        Console.Write("Enter the length :- ");
        float side = float.Parse(Console.ReadLine());
        Console.WriteLine("Area of Square is = " + (side * side));
    }
}

public class Triangle : Shape
{
    public void area()
    {
        Console.WriteLine("****** Calculating the Triangle ******");
        Console.WriteLine("Enter the Width and Height :- ");
        float width = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Area of circle is = " + (0.5*width*height));
        Console.ReadLine();
    }
}

class interfaceProgram {
    public static void Main(string[] args){
        Shape[] s = new Shape[3];
        s[0] = new Circle();
        s[1] = new Sqaure();
        s[2] = new Triangle();

        for (int i = 0; i < s.Length; i++)
        s[i].area();
     }
}