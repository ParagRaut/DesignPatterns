namespace Command;

public class OrderCommand : ICommand
{
    private readonly Chef _chef;
    private readonly string _dish;

    public OrderCommand(Chef chef, string dish)
    {
        _chef = chef;
        _dish = dish;
    }

    public void Execute() => _chef.Prepare(_dish);

    public void Undo() => _chef.Cancel(_dish);
}
