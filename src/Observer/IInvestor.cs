namespace Observer;

public interface IInvestor
{
    void Update(string stockSymbol, decimal price);
}
