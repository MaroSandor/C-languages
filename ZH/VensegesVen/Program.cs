namespace VensegesVen;

public class Program
{
    static void Main(string[] args)
    {
        // Bemenet beolvasása
        List<string> bemenetSorok = new List<string>();
        string sor;

        while (!(sor = Console.ReadLine()).Equals("0"))
        {
            bemenetSorok.Add(sor);
        }

        // Feldolgozás: Értékek szétválogatása
        List<string> nevek = new List<string>();
        List<int> szamok = new List<int>();

        foreach (string bemenet in bemenetSorok)
        {
            string[] adatok = bemenet.Split();

            if (adatok.Length >= 2)
            {
                // Feltételezve, hogy első oszlop: szám, második: név
                if (int.TryParse(adatok[0], out int szam))
                {
                    szamok.Add(szam);
                    nevek.Add(adatok[1]);
                }
            }
        }

        // Kimenet generálása
        for (int i = 0; i < szamok.Count; i++)
        {
            Console.WriteLine($"{szamok[i]} - {nevek[i]}");
        }
    }
}