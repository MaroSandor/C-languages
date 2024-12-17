namespace Account;

class Account
{
    private int id = 0;
    private double balance = 0.0;
    private double annualInterestRate = 5.0;
    private DateTime startDate;

    public Account()
    {
    }

    public Account(int id, double balance)
    {
        this.id = id;
        this.balance = balance;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public double Balance
    {
        get => balance;
        set => balance = value;
    }

    public double AnnualInterestRate
    {
        get => annualInterestRate;
        set => annualInterestRate = value;
    }

    public DateTime StartDate => startDate;

    public double getMonthlyInterestRate()
    {
        return annualInterestRate / 12;
    }

    public void deposit(double money)
    {
        balance += money;
    }

    public void withdraw(double money)
    {
        balance -= money;
    }

    public override string ToString()
    {
        return "Számla egyenlege: " + balance;
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine();

        Account sz1  = new Account();
        Account sz2 = new Account(2, 300);
        
        sz2.deposit(10000);
        Console.WriteLine(sz2.Balance);
        
        sz2.withdraw(1750);
        sz2.Balance = 500;
        Console.WriteLine(sz2.Balance);

    }
}