public class Swimming : Activity
{
    private int _laps;
    public Swimming (DateTime date, int duration, int laps) :
    base (date, duration) {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override float GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }
}