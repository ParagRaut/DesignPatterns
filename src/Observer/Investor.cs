namespace Observer;

public class Investor : IInvestor
{
    private readonly string _name;

    public Investor(string name)
    {
        _name = name;
    }

    public void Update(string stockSymbol, decimal price)
    {
        Console.WriteLine($"  {_name} notified: {stockSymbol} is now {price:C}");
    }
}
