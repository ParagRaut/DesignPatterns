namespace Command;

public class Chef
{
    public void Prepare(string dish) => Console.WriteLine($"  Chef is preparing: {dish}");

    public void Cancel(string dish) => Console.WriteLine($"  Chef cancelled: {dish}");
}
