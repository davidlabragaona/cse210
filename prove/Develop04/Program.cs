using System;
using System.Diagnostics;

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
        /*Activity activity = new Activity();
        Console.Clear();
        activity.ShowSpinner(10);
        activity.ShowCountDown(10);*/
    }

    static string ShowMenuOptions(List<Activity> activities) {
        string response = string.Empty;
        string menuOption = string.Empty;
        Console.WriteLine("Menu Options:");
        for (int i = 0; i < activities.Count; i++) {
            if (activities[i].GetName().ToLower().Contains("quit"))
                menuOption = $"\t{i + 1}. {activities[i].GetName()}";
            else
                menuOption = $"\t{i + 1}. Start {activities[i].GetName()} activity";
            Console.WriteLine(menuOption);
        }
        Console.Write("Select a choice from the menu: ");
        response = Console.ReadLine();
        return response;
    }
}