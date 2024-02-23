public class Cycling : Activity {
    private float _speed;

    public Cycling(DateTime date, int duration, float speed) :
    base(date, duration) {
        _speed = speed;
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