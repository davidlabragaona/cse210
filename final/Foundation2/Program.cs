class Program
{
    static List<Order> _orders = new List<Order>();
    static void Main(string[] args)
    {
        Initialize();
        Console.Clear();
        int i = 0;
        foreach(Order order in _orders) {
            Console.WriteLine($"*** Order {i++ + 1} ***\n");
            Console.WriteLine($"{order.GetPackingLabel()}\nShip to:\n{order.GetShippingLabel()}\n\nTotal: ${order.GetTotalCost():0.00}");
            Console.WriteLine();
        }
    }

    static void Initialize() {
        Customer customer1 = new Customer("Larry King", new Address("405 Washington st", "Grand Rapids", "Michigan", "USA"));
        Customer customer2 = new Customer("Laura Dove", new Address("123 16th st", "Lagrange", "Indiana", "USA"));
        Customer customer3 = new Customer("Henry Sovel", new Address("Salta 95", "San Pedro", "Jujuy", "Argentina" ));

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Table", "US00401", 400, 1));
        order1.AddProduct(new Product("Chair", "US00402", 60, 5));

        _orders.Add(order1);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Linen Sheet Set", "B4380", 65.53f, 2));
        order2.AddProduct(new Product("Towel", "B3731", 20, 2));
        order2.AddProduct(new Product("Soap", "B0032", 1, 3));

        _orders.Add(order2);

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Welcome door mat", "IN342", 5, 1));
        order3.AddProduct(new Product("Alumminum Mug", "IN456", 12.45f, 1));
        
        _orders.Add(order3);
    }
}