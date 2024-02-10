public class QuitActivity : Activity
{
    public QuitActivity() : base ("Quit",
    "",
    "Quit") {

    }

    public void Run() {
        Console.WriteLine("Good bye!");
        SetDuration(1);
    }

    public void SaveLog(List<Activity> activities) {
        _actCount++;
        using (StreamWriter outputFile = new StreamWriter(Program._logFileName)) {
            //We write the header line
            foreach (Activity activity in activities) {
                if (activity.GetDuration() > 0)
                    outputFile.WriteLine($"{activity.GetLogEntry()}");
            }
        }
    }
}