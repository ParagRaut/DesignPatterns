namespace Builder;

public class CustomerBuilder : Builder<Customer>
{
    private readonly Customer _customer = new ();

    public override Customer Build()
    {
        return _customer;
    }

    public CustomerBuilder SetName(string name)
    {
        _customer.Name = name;
        
        return this;
    }

    public CustomerBuilder SetAge(int age)
    {
        _customer.Age = age;

        return this;
    }
}