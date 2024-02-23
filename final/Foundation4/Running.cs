public class Running : Activity
{
    private float _distance;

    public Running(DateTime date, int duration, float distance) :
    base (date, duration) {
        _distance = distance;
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