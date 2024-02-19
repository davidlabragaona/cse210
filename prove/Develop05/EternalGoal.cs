public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base (name, description, points) {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        //Always return false;
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}