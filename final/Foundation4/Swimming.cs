public class Swimming : Activity
{
    private int _laps;
    public Swimming (DateTime date, int duration, int laps) :
    base (date, duration) {
        _laps = laps;
    }

    public override float GetDistance()
    {
        throw new NotImplementedException();
    }

    public override float GetSpeed()
    {
        throw new NotImplementedException();
    }

    public override float GetPace()
    {
        throw new NotImplementedException();
    }
}