public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run() {
        this.DisplayStartingMessage();
        Thread.Sleep(3000);
        this.ShowCountDown(5);
        Console.WriteLine("Now you can proceed");
        this.ShowSpinner(5);
        this.DisplayEndingMessage();
    }

}