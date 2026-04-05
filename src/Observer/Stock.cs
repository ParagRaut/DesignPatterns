namespace Observer;

public class Stock
{
    private readonly string _symbol;
    private decimal _price;
    private readonly List<IInvestor> _investors = [];

    public Stock(string symbol, decimal initialPrice)
    {
        _symbol = symbol;
        _price = initialPrice;
    }

    public void Register(IInvestor investor) => _investors.Add(investor);

    public void Unregister(IInvestor investor) => _investors.Remove(investor);

    public void UpdatePrice(decimal newPrice)
    {
        Console.WriteLine($"\n{_symbol} price changed: {_price:C} -> {newPrice:C}");
        _price = newPrice;
        NotifyAll();
    }

    private void NotifyAll()
    {
        foreach (var investor in _investors)
        {
            investor.Update(_symbol, _price);
        }
    }
}
