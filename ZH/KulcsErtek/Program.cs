namespace KulcsErtek;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> countrys = new Dictionary<string, string>();
        
        countrys.Add("Hungary", "Budapest");
        countrys.Add("Austria", "Bucharest");

        foreach (var value in countrys.Values.ToList())
        {
            Console.WriteLine(value);
        }

        countrys["Austria"] = "RandomCity";
        
        foreach (var value in countrys.Values.ToList())
        {
            Console.WriteLine(value);
        }
    }
}