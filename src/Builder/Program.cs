using Builder;

var builder = new CustomerBuilder();

builder
    .SetName("Parag")
    .SetAge(33);

var customer = builder.Build();

Console.WriteLine(customer);