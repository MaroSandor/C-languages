namespace Sztringek;

public class Program
{
    public static void Main(string[] args)
    {
        string s1 = "Welcome to Java";
        string s2 = s1;
        string s3 = new String("Welcome to Java");
        string s4 = "Welcome to Java";
        string s5 = "semmi";

        Console.WriteLine(s1 == s2);
        Console.WriteLine(s2 == s3);
        Console.WriteLine(s1 == s4);
        Console.WriteLine(s1.Equals(s2));
        Console.WriteLine(s2.Equals(s3));
        Console.WriteLine(s1.CompareTo(s2));
        Console.WriteLine(s2.CompareTo(s3));
        Console.WriteLine(s2.CompareTo(s5));
        Console.WriteLine(s2.CompareTo(s5));
        Console.WriteLine(s1[0]);
        Console.WriteLine(s1.IndexOf('j'));
        Console.WriteLine(s1.IndexOf("to"));
        Console.WriteLine(s1.LastIndexOf('a'));
        Console.WriteLine(s1.LastIndexOf("o", 15));
        Console.WriteLine(s1.Length);
        Console.WriteLine(s1.Substring(5));
        Console.WriteLine(s1.Substring(5, 11));
        Console.WriteLine(s1.StartsWith("Wel"));
        Console.WriteLine(s1.EndsWith("Java"));
        Console.WriteLine(s1.ToLower());
        Console.WriteLine(s1.ToUpper());
        Console.WriteLine(" Welcome".Trim());
        Console.WriteLine(s1.Replace('o', 'T'));
    }
}