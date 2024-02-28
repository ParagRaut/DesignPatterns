using ChainOfResponsibility;

var vipHandler = new VipDiscountHandler();
var regularHandler =  new RegularDiscountHandler();
var newCustomerHandler = new NewCustomerDiscountHandler();
var noDiscountHandler = new NoDiscountHandler();

vipHandler.SetNextHandler(regularHandler);
regularHandler.SetNextHandler(newCustomerHandler);
newCustomerHandler.SetNextHandler(noDiscountHandler);

decimal discountAmount = vipHandler.CalculateDiscount(new Customer(true, false, false), 100);

Console.WriteLine($"Discount given was: {discountAmount}");