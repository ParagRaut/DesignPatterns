namespace Decorator;

public class WhipCreamDecorator : CoffeeDecorator
{
    public WhipCreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => $"{_coffee.GetDescription()}, whip cream";

    public override decimal GetCost() => _coffee.GetCost() + 0.75m;
}
