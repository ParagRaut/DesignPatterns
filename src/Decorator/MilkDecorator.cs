namespace Decorator;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => $"{_coffee.GetDescription()}, milk";

    public override decimal GetCost() => _coffee.GetCost() + 0.50m;
}
