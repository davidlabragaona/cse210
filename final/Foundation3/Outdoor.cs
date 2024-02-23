public class Outdoor : Event
{
    private string _forecast;

    public Outdoor(string title, string description, DateTime dateTime, Address address, string forecast) : 
    base(title, description, dateTime, address) {
        _forecast = forecast;
    }
    public override string GetFullDetails()
    {
        throw new NotImplementedException();
    }

    public override string GetShortDescription()
    {
        throw new NotImplementedException();
    }

}