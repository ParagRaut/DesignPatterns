namespace Decorator;

public class SimpleCoffee : ICoffee
{
    public string GetDescription() => "Simple coffee";

    public decimal GetCost() => 2.00m;
}
