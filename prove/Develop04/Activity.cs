using System.Drawing;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity (string name, string description) {
        _name = name;
        _description = description;
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

    public void DisplayStartingMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}");
    }

    public void DisplayEndingMessage() {
        Console.WriteLine($"Well done!!\n\n You have completed another {_duration} of the {_name} Activity.");
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
            Thread.Sleep(1000);
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
    }

    public void DisplayMenuEntry() {

    }
}