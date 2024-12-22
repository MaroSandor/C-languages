using System.Reflection.Metadata.Ecma335;

namespace Katasztrofa;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Add meg az évszámot!");
            return;
        } else if (args.Length != 1)
        {
            Console.WriteLine("Hiba! Csak egy évszámot adj meg!");
            return;
        }
        
        try
        {
            var sor = File.ReadAllLines("adatok.txt");
            
            var katasztrofa = sor
                .Select(line => line.Split(", "))
                .Select(parts => new Katasztrofa(Convert.ToInt32(parts[0]), parts[1]))
                .ToList();

            var afterThisYear = katasztrofa
                .Where(obj => obj.Evszam > int.Parse(args[0]))
                .OrderBy(obj => obj.Evszam)
                .ThenBy(obj => obj.Katasztrofa1);
            
            foreach (var d in afterThisYear)
            {
                Console.WriteLine($"{d.Evszam}: {d.Katasztrofa1}");
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}