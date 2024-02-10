using System.Drawing;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected int _actCount;
    protected int _actTotalDuration;

    private string _menuEntry;

    public Activity (string name, string description, string menuEntry) {
        _name = name;
        _description = description;
        _menuEntry = menuEntry;
    }

    public string GetName() {
        return _name;
    }

    public string GetDescription() {
        return _description;
    }

    public void SetDescription(string description) {
        _description = description;
    }

    public void SetDuration(int seconds) {
        _duration = seconds;
    }

    public int GetDuration() {
        return _duration;
    }

    public void DisplayStartingMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {GetName()} Activity.\n\n{GetDescription()}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
    }

    public void DisplayEndingMessage() {
        Console.WriteLine($"Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetName()} Activity.");
    }

    public void ShowSpinner (int seconds) {
        ConsoleColor color = Console.ForegroundColor;
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        int i = 0;
        Console.ForegroundColor = ConsoleColor.Green;

        while (DateTime.Now < end) {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i == spinner.Count)
                i = 0;
        }
        Console.ForegroundColor = color;
    }

    public void ShowCountDown (int seconds) {
        ConsoleColor color = Console.ForegroundColor;
        while (seconds > 0) {
            if (seconds > 5)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (seconds > 3)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            Console.Write($"{seconds--:00}");
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
        }
        Console.ForegroundColor = color;
    }

    public string DisplayMenuEntry() {
        return _menuEntry;
    }

    public string GetLogEntry() {
        DateTime dateTime = DateTime.Now;
        return $"[{dateTime:yyyy-MM-dd HH:mm}]: activity: {GetName()} - duration: {GetDuration()} - repetition: {_actCount}";
    }
}