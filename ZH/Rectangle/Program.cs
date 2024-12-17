namespace Rectangle;

class Rectangle
{
    public double width = 1.0;
    public double height = 1.0;

    public Rectangle()
    {
    }

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double GetArea()
    {
        return width * height;
    }

    public double GetPerimeter()
    {
        return 2 * ( width + height );
    }

    public override string ToString()
    {
        return "Téglalap területe: " + GetArea() + " cm2, kerülete: " + GetPerimeter() + "cm";
    }
}

internal class MainMethod
{
    public static void Main(string[] args)
    {
        Rectangle rectangle1 = new Rectangle();
        Rectangle rectangle2 = new Rectangle();
        
        rectangle2.width = 3.0;
        rectangle2.height = 4.5;
        
        Rectangle rectangle3 = new Rectangle(2.8,3.6);

        Console.WriteLine(rectangle1.ToString());
        Console.WriteLine(rectangle2.ToString());
        Console.WriteLine(rectangle3.ToString());
    }
}