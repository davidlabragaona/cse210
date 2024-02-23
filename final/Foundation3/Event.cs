public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public string GetStandardDetails() {
        return "";
    }

    public abstract string GetFullDetails();

    public abstract string GetShortDescription();

    public Event(string title, string description, DateTime dateTime, Address address) {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

}