namespace Fan;

public class Fan
{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    public int speed = SLOW;
    public bool on = false;
    public double radius = 5;
    public string color = "blue";

    public Fan() { }

    public int Speed
    {
        get => speed;
        set => speed = value;
    }

    public bool On
    {
        get => on;
        set => on = value;
    }

    public double Radius
    {
        get => radius;
        set => radius = value;
    }

    public string Color
    {
        get => color;
        set => color = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public override string ToString()
    {
        if (on)
        {
            return "Ventillátor sebessége: " + speed + ", szine: " + color + ", sugara: " + radius;
        }

        return "Fan is off.";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;

        Fan other = (Fan) obj;
        
        return color.Equals(other.color) && radius == other.radius;
    }
}