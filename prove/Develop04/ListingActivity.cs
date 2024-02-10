
public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts = new List<string>();
    private List<int> _usedPrompts = new List<int>();
    private List<string> _list = new List<string>();

    public ListingActivity() : base (
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        "Start listing activity"
    )
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run() {
        _actCount++;
        string prompt = string.Empty;

        this.DisplayStartingMessage();
        prompt = Console.ReadLine();
        this.SetDuration(int.Parse(prompt.Trim()));
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end) {
            Console.Write("> ");
            _list.Add(Console.ReadLine());
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!\n");

        this.DisplayEndingMessage();
        ShowSpinner(5);

        using (StreamWriter outputFile = new StreamWriter(Program._logFileName)) {
            outputFile.WriteLine($"{GetLogEntry()}");
        }

    }

    public void GetRandomPrompt() {
        int index = 0;
        bool exitLoop = false;
        while (!exitLoop) {
            index = new Random().Next(0, _prompts.Count);
            if (_usedPrompts.IndexOf(index) == -1) {
                _usedPrompts.Add(index);
                exitLoop = true;
            } else
                continue;
        }
        Console.WriteLine($" --- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser() {
        return _list;
    }


}