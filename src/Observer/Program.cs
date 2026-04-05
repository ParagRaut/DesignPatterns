using Observer;

var apple = new Stock("AAPL", 150.00m);

var parag = new Investor("Parag");
var alice = new Investor("Alice");
var bob = new Investor("Bob");

// Everyone subscribes
apple.Register(parag);
apple.Register(alice);
apple.Register(bob);

apple.UpdatePrice(155.50m);

// Bob unsubscribes — he's out
apple.Unregister(bob);

apple.UpdatePrice(160.75m);
