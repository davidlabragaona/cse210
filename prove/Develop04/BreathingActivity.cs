public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing",
    "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
    "Start breathing activity")
    {

    }

    public void Run() {
        string prompt = string.Empty;

        this.DisplayStartingMessage();
        prompt = Console.ReadLine();
        this.SetDuration(int.Parse(prompt.Trim()));
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < GetDuration() / 10; i++) {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine("\n");
        }
        this.DisplayEndingMessage();
        ShowSpinner(5);
    }

}