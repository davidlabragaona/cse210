class Program
{
    static List<Event> _events = new List<Event>();

    static void Initialize() {

        Lecture lecture = new Lecture("C# Basics", "Learn C# programming basics", new DateTime(2024, 3, 15),
            new Address("123 Main St", "Lagrange", "IN", "USA"), "William Shutter", 40);
        
        Reception reception = new Reception("Get to know your coworkers", "A great time with your coworkers outside the job",
            new DateTime(2024, 06, 30),
            new Address("789 Oak St", "Battle Creek", "NY", "USA"), "rsvp@event.com");

        Outdoor outdoor = new Outdoor("Summer Picnic", "Enjoy some delicious meals connected with nature",
            new DateTime(2024, 6, 20),
            new Address("456 Elm St", "Black River", "FL", "USA"), "Sunny");

        _events.Add(lecture);
        _events.Add(reception);
        _events.Add(outdoor);

    }
    static void Main(string[] args)
    {
        Initialize();
        Console.Clear();
        Console.WriteLine("Activities to remember:");

        foreach (Event item in _events)
        {
            Console.WriteLine(item.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(item.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine(item.GetFullDetails());
        }
    }
}