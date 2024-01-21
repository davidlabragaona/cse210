public class PromptGenerator {
    public static List<string> _prompts = new List<string>();

    static PromptGenerator() {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public static string GetRandomPrompt() {
        int i = new Random().Next(0, _prompts.Count);
        return _prompts[i];
    }
}