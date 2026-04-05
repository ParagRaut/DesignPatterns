namespace Decorator;

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => $"{_coffee.GetDescription()}, sugar";

    public override decimal GetCost() => _coffee.GetCost() + 0.25m;
}
