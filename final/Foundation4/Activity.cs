public abstract class Activity
{
    private DateTime _date;
    private int _duration; //minutes

    public Activity (DateTime date, int duration) {
        _date = date;
        _duration = duration;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_duration} min): " +
               $"Distance {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

}