namespace ChainOfResponsibility;

public abstract class DiscountHandler
{
    protected DiscountHandler? NextHandler;

    public void SetNextHandler(DiscountHandler? nextHandler)
    {
        NextHandler = nextHandler;
    }

    public abstract decimal CalculateDiscount(Customer customer, decimal orderTotal);
}