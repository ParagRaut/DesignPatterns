using Decorator;

// Start with a simple coffee
ICoffee coffee = new SimpleCoffee();
Console.WriteLine($"{coffee.GetDescription()} = {coffee.GetCost():C}");

// Add milk
coffee = new MilkDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} = {coffee.GetCost():C}");

// Add sugar
coffee = new SugarDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} = {coffee.GetCost():C}");

// Add whip cream — decorators stack!
coffee = new WhipCreamDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} = {coffee.GetCost():C}");
