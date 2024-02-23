public class Cycling : Activity {
    private float _speed;

    public Cycling(DateTime date, int duration, float speed) :
    base(date, duration) {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * GetDuration() / 60;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60 / GetSpeed();
    }

}