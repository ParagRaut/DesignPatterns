namespace ChainOfResponsibility;

public class VipDiscountHandler : DiscountHandler
{
    public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
    {
        if (customer.IsVip)
        {
            return orderTotal * 0.8m; // 20% discount
        }

        return NextHandler?.CalculateDiscount(customer, orderTotal) ?? orderTotal;
    }
}