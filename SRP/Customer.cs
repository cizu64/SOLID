using System.Text.Json;

public class Customer
{
    List<CustomerDTO> lst = null;
    public Customer()
    {
        lst = new();
    }
    public void AddCustomer(CustomerDTO customer)
    {
        lst.Add(customer);
        Log.AddLogs($"{customer.Fullname} added");
    }

    public string DisplayCustomer()
    {
        string customer = JsonSerializer.Serialize(lst);
        Log.AddLogs($"customers retrieved\n{customer}");
        return customer;
    }
}