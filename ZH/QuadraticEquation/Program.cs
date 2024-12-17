namespace QuadraticEquation;

class QuadraticEquation
{
    private double a;
    private double b;
    private double c;

    public QuadraticEquation(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double A => a;

    public double B => b;

    public double C => c;

    public double GetDiscriminant()
    {
        return Math.Pow(b, 2) - 4 * a * c;
    }

    public double GetRoot1()
    {
        double discriminant = GetDiscriminant();
        
        if (discriminant > 0)
        {
            return (-1 * b + Math.Sqrt(discriminant) ) / 2 * a;
        }

        return 0;
    }

    public double GetRoot2()
    {
        double discriminant = GetDiscriminant();
        
        if (discriminant > 0)
        {
            return (-1 * b - Math.Sqrt(discriminant) ) / 2 * a;
        }

        return 0;
    }

    public override string ToString()
    {
        return "Másodfokú egyenlet gyökei: x1=" + GetRoot1() + ", x2=" + GetRoot2();
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        QuadraticEquation qe1 = new QuadraticEquation(2.0, 3.0, 4.0);
        QuadraticEquation qe2 = new QuadraticEquation(7.0, 5.0, -2.0);
        QuadraticEquation qe3 = new QuadraticEquation(1.0, -3.0, 8.0);

        if (qe1.GetDiscriminant() > 0)
        {
            Console.WriteLine(qe1.ToString());
        }
        else
        {
            Console.WriteLine("The equation has no roots.");
        }
        
        if (qe2.GetDiscriminant() > 0)
        {
            Console.WriteLine(qe2.ToString());
        }
        else
        {
            Console.WriteLine("The equation has no roots.");
        }
        
        if (qe3.GetDiscriminant() > 0)
        {
            Console.WriteLine(qe3.ToString());
        }
        else
        {
            Console.WriteLine("The equation has no roots.");
        }
    }
}