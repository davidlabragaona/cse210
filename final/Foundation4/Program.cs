class Program
{
    static List<Activity> _activities = new List<Activity>();
    
    static void Main(string[] args)
    {
        Initialize();
        Console.WriteLine();

        Console.WriteLine("Fitness Center - Activity");

        foreach(Activity activity in _activities) {
            Console.WriteLine(activity.GetSummary());
        }
    }

    static void Initialize() {
        Running running = new Running(new DateTime(2024, 7, 20), 20, 9.08f);
        _activities.Add(running);
        Running running1 = new Running(new DateTime(2024, 8, 15), 30, 4.8f);
        _activities.Add(running1);
        Cycling cycling = new Cycling(DateTime.Now, 60, 10);
        _activities.Add(cycling);
        Swimming swimming = new Swimming(new DateTime(2024, 09, 20), 30, 30);
        _activities.Add(swimming);
    }
}