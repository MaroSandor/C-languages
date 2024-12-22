namespace Katasztrofa;

public class Katasztrofa
{
    private int evszam;
    private string katasztrofa;

    public Katasztrofa(int evszam, string katasztrofa)
    {
        this.evszam = evszam;
        this.katasztrofa = katasztrofa;
    }

    public int Evszam
    {
        get => evszam;
        set => evszam = value;
    }

    public string Katasztrofa1
    {
        get => katasztrofa;
        set => katasztrofa = value ?? throw new ArgumentNullException(nameof(value));
    }

    public override string ToString()
    {
        return "Katasztrófa: " + katasztrofa + "(" + evszam + ")";
    }
}