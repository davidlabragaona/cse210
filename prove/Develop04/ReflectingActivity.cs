using System.Diagnostics;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<int> _usedPrompts = new List<int>();
    private List<string> _questions = new List<string>();
    private List<int> _usedQuestions = new List<int>();

    public ReflectingActivity() : base (
        "Reflecting",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        "Start reflecting activity"
    )
    {
        //Fill the prompts
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        //Fill the questions
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run () {
        _actCount++;
        string prompt = string.Empty;

        this.DisplayStartingMessage();
        prompt = Console.ReadLine();
        this.SetDuration(int.Parse(prompt.Trim()));
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
        if (_prompts.Count != _usedPrompts.Count) {
            DisplayPrompt();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            Console.Write("You may begin in: ");
            ShowCountDown(5);

            if (_questions.Count != _usedQuestions.Count) {
                Console.Clear();
                DisplayQuestions();
            }
            else {
                Console.WriteLine("You have completed the questions for this session.");
            }
        }
        else {
            Console.WriteLine("You have completed the prompts for this session.");
        }

        this.DisplayEndingMessage();
        ShowSpinner(5);

        using (StreamWriter outputFile = new StreamWriter(Program._logFileName)) {
            outputFile.WriteLine($"{GetLogEntry()}");
        }
    }

    public string GetRandomPrompt() {
        int index = 0;
        bool exitLoop = false;
        while (!exitLoop) {
            if (_prompts.Count == _usedPrompts.Count)
                exitLoop = true;
            index = new Random().Next(0, _prompts.Count);
            if (_usedPrompts.IndexOf(index) == -1) {
                _usedPrompts.Add(index);
                exitLoop = true;
            }
        }
        return _prompts[index];
    }

    public string GetRandomQuestion() {
        int index = 0;
        bool exitLoop = false;
        while (!exitLoop) {
            if (_questions.Count == _usedQuestions.Count)
                exitLoop = true;
            index = new Random().Next(0, _questions.Count);
            if (_usedQuestions.IndexOf(index) == -1) {
                _usedQuestions.Add(index);
                exitLoop = true;
            }
        }
        return _questions[index];
    }

    public void DisplayPrompt() {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.\n");
        Console.ReadKey(true);
    }

    public void DisplayQuestions() {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(10);
        Console.WriteLine();
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(10);
        Console.WriteLine();
        Console.WriteLine();
    }
}