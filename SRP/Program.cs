// See https://aka.ms/new-console-template for more information

Customer c = new();
c.AddCustomer(new CustomerDTO{
    Id=1,
    Fullname = "John Doe",
    Email = "johndoe@gmail.col"
});
c.DisplayCustomer();