namespace Fan;

public class Program
{
    public static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        fan1.Speed = Fan.FAST;
        fan1.radius = 10;
        fan1.color = "yellow";
        fan1.on = true;
        
        Fan fan2 = new Fan();
        fan2.speed = Fan.MEDIUM;
        fan2.radius = 5;
        fan2.color = "blue";
        fan2.on = false;

        Console.WriteLine(fan1.ToString());
        Console.WriteLine(fan2.ToString());
    }
}