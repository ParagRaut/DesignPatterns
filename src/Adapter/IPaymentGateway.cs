namespace Adapter;

public interface IPaymentGateway
{
    void ProcessPayment(string customerEmail, decimal amount, string currency);
}
