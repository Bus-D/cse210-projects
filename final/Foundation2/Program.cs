using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("15 N 3rd East", "Provo", "Utah", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Product product1 = new Product("Guitar", 001, 50.25, 1);
        Product product2 = new Product("Basketball", 002, 25.52, 6);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address("15 Church Ln", "London", "City of London", "England");
        Customer customer2 = new Customer("Alyssa Smith", address2);
        Product product3 = new Product("Bacon", 003, 5.29, 3);
        Product product4 = new Product("Milk", 004, 3.27, 2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 1");
        Console.WriteLine($"{order1.GetPackingLabel()}");
        Console.WriteLine($"{order1.GetShippingLabel()}");
        Console.WriteLine($"{order1.GetTotalPrice()}\n");

        Console.WriteLine("Order 2");
        Console.WriteLine($"{order2.GetPackingLabel()}");
        Console.WriteLine($"{order2.GetShippingLabel()}");
        Console.WriteLine($"{order2.GetTotalPrice()}\n");
    }
}