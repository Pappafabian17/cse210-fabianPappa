using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("keyboard","K721", 79.98m, 2);
        Product product2 = new Product("TV-Samsung 33 inch","TV3312432", 157.92m, 4);
        Address address = new Address("Siempre viva AV.", "Springfield", "Idaho", "ARG");

        Customer customer = new Customer("Fabian", address);

        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);
        Order order = new Order(products, customer);

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: {order.CalculateTotalPrice()}");
    }
}