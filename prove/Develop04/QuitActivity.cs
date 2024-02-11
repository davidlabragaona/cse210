public class QuitActivity : Activity
{
    public QuitActivity() : base ("Quit",
    "",
    "Quit") {

    }

    public void Run() {
        _actCount++;
        SetDuration(1);
        Console.WriteLine("Good bye!");
    }

    public void SaveLog(List<Activity> activities) {
        using (StreamWriter outputFile = new StreamWriter(Program._logFileName, true)) {
            
            foreach (Activity activity in activities) {
                if (activity.GetDuration() > 0)
                    outputFile.WriteLine($"{activity.GetLogEntry()}");
            }
        }
    }
}