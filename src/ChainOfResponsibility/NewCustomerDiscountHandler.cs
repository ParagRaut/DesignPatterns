namespace ChainOfResponsibility;

public class NewCustomerDiscountHandler : DiscountHandler
{
    public override decimal CalculateDiscount(Customer customer, decimal orderTotal)
    {
        if (customer.IsNew)
        {
            return orderTotal * 0.95m; // 5% discount
        }

        return NextHandler?.CalculateDiscount(customer, orderTotal) ?? orderTotal;
    }
}