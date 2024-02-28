namespace Builder;

public class Customer
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public override string ToString()
    {
        return $"Customer's name: {Name} & age: {Age}";
    }
}