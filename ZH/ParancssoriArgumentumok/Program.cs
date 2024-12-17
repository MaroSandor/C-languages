using System.Collections.ObjectModel;

// A program leirása:
// A parancssorról olvasson be számokat (min: 3, max: nicns megadva), ezeket rendezze növekvő sorrendbe,
// és minden 4. elemet vizsgáljon meg, hogy prim szám-e. Ha igen, akkor adja hozzá egy tömbhöz és irja ki a konzolra egy sorb an szóközzel elválasztva.

internal class CommandLineArguments
{
    public static void Main(string[] args)
    {
        int[] sortedNumbers = new int[args.Length];

        for (int i = 0; i < args.Length; i++)
        {
            sortedNumbers[i] = Convert.ToInt32(args[i]);
        }

        Array.Sort(sortedNumbers);

        Console.WriteLine("Rendezett elemek:");
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number + " ");
        }
        
        HashSet<int> uniqueNumbers = new HashSet<int>();

        foreach (int number in sortedNumbers)
        {
            uniqueNumbers.Add(number);
        }

        foreach (int number in uniqueNumbers)
        {
            Console.Write(number + " ");
        }
    }
}