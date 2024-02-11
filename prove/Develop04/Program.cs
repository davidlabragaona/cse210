using System;
using System.Text;

// Exceeding requirements
// 1. Quit Activity
// 2. Save Log with duration and repetition
// 3. Spinner and Coundown with colors
// 4. GetRandomQuestions and Prompts without repeating

class Program
{
    public static string _logFileName = "activity.log";
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        BreathingActivity breathingActivity = new BreathingActivity();
        activities.Add(breathingActivity);

        ReflectingActivity reflectingActivity = new ReflectingActivity();
        activities.Add(reflectingActivity);

        ListingActivity listingActivity = new ListingActivity();
        activities.Add(listingActivity);

        QuitActivity quitActivity = new QuitActivity();
        activities.Add(quitActivity);

        bool exit = false;
        string option = string.Empty;
        while(!exit) {
            option = ShowMenuOptions(activities);
            if (option == "1")
                breathingActivity.Run();
            if (option == "2")
                reflectingActivity.Run();
            if (option == "3")
                listingActivity.Run();    
            if (option == "4") {
                quitActivity.Run();
                quitActivity.SaveLog(activities);
                exit = true;
            }
        }
    }

    static string ShowMenuOptions(List<Activity> activities) {
        int i = 0;
        string option = string.Empty;
        Console.Clear();
        Console.WriteLine("Menu Options:");
        foreach (Activity activity in activities) {
            Console.WriteLine($"\t{++i}. {activity.DisplayMenuEntry()}");
        }
        Console.Write("Select a choice from the menu: ");
        option = Console.ReadLine().Trim();
        return option;
    }
}