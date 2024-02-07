using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        BreathingActivity breathingActivity = new BreathingActivity();
        activities.Add(breathingActivity);

        QuitActivity exitActivity = new QuitActivity();
        activities.Add(exitActivity);

        bool exit = false;
        while(!exit) {
            ShowMenuOptions(activities);
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