namespace ChainOfResponsibility;

public class NoDiscountHandler : DiscountHandler
{
    public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
    {
        return orderTotal; // no discount
    }
}