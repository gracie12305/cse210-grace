using System;

class Program
{
    static void Main(string[] args)
    {
          // Address 1 (USA)
        Address address1 = new Address("45 BRT Road", "Strongstreet", "SA", "Eswatini");

        // Customer 1
        Customer customer1 = new Customer("Emily Stuart", address1);

        // Products for Order 1
        Product product1 = new Product("High Heels", 101, 80, 2);  // High Heels, $80 each
        Product product2 = new Product("Curly Frontal Wig", 102, 200, 1);  // 1 Curly Frontal Wig, $200 each

        // Order 1
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });

        // Address 2 (Non-USA)
        Address address2 = new Address("345 Langa St", "Mataffin", "SA", "South Africa");

        // Customer 2
        Customer customer2 = new Customer("Grace Smith", address2);

        // Products for Order 2
        Product product3 = new Product("Wallet", 201, 50, 2);  // 2 wallets, $50 each
        Product product4 = new Product("Phonecase", 202, 18, 10);  // 10 phonecases, $18 each

        // Order 2
        Order order2 = new Order(customer2, new List<Product> { product3, product4 });

        // Display results for Order 1
        Console.WriteLine("Order 1:");
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");
        Console.WriteLine("Package Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Adress:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(new string('-', 40));

        // Display results for Order 2
        Console.WriteLine("Order 2:");
         Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
        Console.WriteLine("Package Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Adress:");
        Console.WriteLine(order2.ShippingLabel());
    }
    }
