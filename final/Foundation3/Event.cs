public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public string GetStandardDetails() {
        return $"{_title}, {_description}, {_dateTime.ToShortDateString()}, {_address.GetAddressString()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription() {
        return $"{GetType().Name}: {_title} - {_dateTime.ToShortDateString()}";
    }

    public Event(string title, string description, DateTime dateTime, Address address) {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

}