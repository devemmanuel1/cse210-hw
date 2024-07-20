using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("84 Refiners estate", "Emene", "Enugu", "Nigeria");
        Customer customer1 = new Customer("Emmanuel Ezechukwu", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product(1, "Mop", 5.99, 2);
        Product product2 = new Product(2, "Piggy Bank", 15.00, 1);
        Product product3 = new Product(3, "Soccer", 8.50, 4);
        order1.AddProduct(product1);
        order1. AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("84 Refiners estate", "Emene", "Enugu", "Nigeria");
        Customer customer2 = new Customer("Miriam Kamsi", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product(4, "Dog Bone", 1.99, 1);
        Product product5 = new Product(5, "Fish Bowl", 35.50, 5);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.Clear();
        Console.WriteLine("Order 1");
        Console.Write("Packing Label:");
        Console.WriteLine(order1.ToStringPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ToStringShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");
        Console.WriteLine();
        
        Console.WriteLine("Order 2");
        Console.Write("Packing Label:");
        Console.WriteLine(order2.ToStringPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ToStringShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
    }
}