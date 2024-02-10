using System;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        BreathingActivity breathingActivity = new BreathingActivity();
        activities.Add(breathingActivity);
        QuitActivity quitActivity = new QuitActivity();
        activities.Add(quitActivity);

        bool exit = false;
        string option = string.Empty;
        while(!exit) {
            option = ShowMenuOptions(activities);
            if (option == "1")
                breathingActivity.Run();
            if (option == "2") {
                quitActivity.Run();
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