namespace Strategy;

public class CreditCardPayment : IPaymentStrategy
{
    private readonly string _cardNumber;

    public CreditCardPayment(string cardNumber)
    {
        _cardNumber = cardNumber;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Paid {amount:C} using Credit Card ending in {_cardNumber[^4..]}");
    }
}
