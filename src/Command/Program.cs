using Command;

var chef = new Chef();
var waiter = new Waiter();

// Place orders — each is a command object
var pasta = new OrderCommand(chef, "Pasta Carbonara");
var steak = new OrderCommand(chef, "Ribeye Steak");
var salad = new OrderCommand(chef, "Caesar Salad");

waiter.TakeOrder(pasta);
waiter.TakeOrder(steak);
waiter.TakeOrder(salad);

Console.WriteLine();

// Customer changed their mind — undo the last order
waiter.UndoLastOrder();
