namespace Command;

public class Waiter
{
    private readonly List<ICommand> _orderHistory = [];

    public void TakeOrder(ICommand command)
    {
        Console.WriteLine("Waiter sends order to kitchen:");
        command.Execute();
        _orderHistory.Add(command);
    }

    public void UndoLastOrder()
    {
        if (_orderHistory.Count == 0)
        {
            Console.WriteLine("No orders to undo.");
            return;
        }

        var lastCommand = _orderHistory[^1];
        _orderHistory.RemoveAt(_orderHistory.Count - 1);
        Console.WriteLine("Waiter cancels last order:");
        lastCommand.Undo();
    }
}
