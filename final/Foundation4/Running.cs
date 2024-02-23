public class Running : Activity
{
    private float _distance;

    public Running(DateTime date, int duration, float distance) :
    base (date, duration) {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }

    public override float GetPace()
    {
        return GetDuration() / _distance;
    }

}